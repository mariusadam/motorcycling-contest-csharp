using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generated;
using Microsoft.Practices.Unity;
using MotorcyclingContestApp.Client;
using MotorcyclingContestApp.Domain;

namespace MotorcyclingContestApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly IClientProxy _client;

        public MainForm([Dependency()] IClientProxy client)
        {
            _client = client;
            InitializeComponent();

            InitializeTabs();
        }

        private void InitializeTabs()
        {
            var contestants = _client.GetContestants();
            AddContestantsToGrid(contestantsGrid, contestants);
            AddContestantsToGrid(searchContestantsGrid, contestants);

            AddAllTeams();
            AddAllRaces();

            cEngineCapacityComboBox.Items.Clear();
            cEngineCapacityComboBox.Items.AddRange(_client.GetEngineCapacities().ToArray());

            cRacesListBox.Items.Clear();
            cRacesListBox.Items.AddRange(_client.GetRaces().ToArray());

            var events = Enum.GetValues(typeof(EventName)).Cast<EventName>().ToList();
            _client.Subscribe(events, HandleEvent);
        }

        private void AddAllTeams()
        {
            cTeamComboBox.Items.Clear();
            cTeamComboBox.Items.AddRange(_client.GetTeams().ToArray());
        }

        private void AddAllRaces()
        {
            racesGrid.Rows.Clear();
            Action<Race, int> addRow = (race, count) =>
            {
                racesGrid.Rows.Add(
                    race.Id,
                    race.Name,
                    race.StarTime,
                    count
                );
            };

            _client.GetRacesParticipants(addRow);
        }

        private void HandleEvent(Domain.Event e)
        {
            switch (e.Name)
            {
                case EventName.ContestantRegistered:
                    var contestants = _client.GetContestants();
                    AddContestantsToGrid(contestantsGrid, contestants);
                    searchByTeamButton_Click(null, null);
                    AddAllRaces();
                    break;
                case EventName.TeamAdded:
                    AddAllTeams();
                    break;
                default:
                    break;
            }
        }

        private void AddContestantsToGrid(DataGridView grid, IEnumerable<Contestant> contestants)
        {
            grid.Rows.Clear();
            foreach (var c in contestants)
            {
                grid.Rows.Add(
                    c.Id,
                    c.Name,
                    c.Team.Name,
                    c.EngineCapacity
                );
            }
        }

        private void AddFormToPanel(Panel panel, Form form)
        {
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (var loginForm = DependencyFactory.Resolve<LoginForm>())
            {
                Hide();
                loginForm.ShowDialog();
                Close();
            }
        }

        private void searchByTeamButton_Click(object sender, EventArgs e)
        {
            try
            {
                var contestants = _client.SearchContestatns(teamNameSearchTextBox.Text);
                AddContestantsToGrid(searchContestantsGrid, contestants);
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private void Error(string message)
        {
            MessageBox.Show(
                message, "An error occured",
                MessageBoxButtons.OK, MessageBoxIcon.Error
            );
        }

        private void Info(string message)
        {
            MessageBox.Show(
                message,
                @"Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void resetContestantButton_Click(object sender, EventArgs e)
        {
            cNameTextBox.Text = "";
            cEngineCapacityComboBox.SelectedText = "";
            cTeamComboBox.SelectedText = "";
            cRacesListBox.ClearSelected();
        }

        private void registerContestantButton_Click(object sender, EventArgs e)
        {
            if (cTeamComboBox.SelectedItem == null && cTeamComboBox.Text != "")
            {
                TryAddTeam();
                return;
            }

            var errors = new List<string>();
            if (cEngineCapacityComboBox.SelectedItem == null)
            {
                errors.Add("You must select an engine capacity!");
            }

            if (cRacesListBox.CheckedItems.Count < 1)
            {
                errors.Add("You must select at least one race!");
            }
            if (cTeamComboBox.Text == "")
            {
                errors.Add("Team name cannot be empty!");
            }

            if (errors.Count > 0)
            {
                Error(string.Join("\n", errors));
                return;
            }

            var team = (Team) cTeamComboBox.SelectedItem;
            var ec = (EngineCapacity) cEngineCapacityComboBox.SelectedItem;
            var races = (from object checkedItem in cRacesListBox.CheckedItems select checkedItem as Race).ToList();

            try
            {
                _client.RegisterContestant(
                    cNameTextBox.Text,
                    team,
                    ec,
                    races
                );
                Info(@"The contestant was added!");
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private void TryAddTeam()
        {
            DialogResult result = MessageBox.Show(
                @"Do you want to add a new team?",
                @"Confirmation",
                MessageBoxButtons.YesNoCancel
            );
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _client.AddTeam(cTeamComboBox.Text);
                SelectTeamBasedOnInput();
                Info(@"The new team was succesfully added.");
            }
            catch (Exception e)
            {
                Error(e.Message);
            }
        }

        private void SelectTeamBasedOnInput()
        {
            cTeamComboBox.SelectedIndex = cTeamComboBox.FindStringExact(cTeamComboBox.Text);
            return;
            int selectedIndex = -1;
            foreach (var item in cTeamComboBox.Items)
            {
                selectedIndex++;
                var team = (Team)item;
                if (team.Name.Contains(cTeamComboBox.Text))
                {
                    break;
                }
            }
            if (selectedIndex != -1)
            {
                cTeamComboBox.SelectedIndex = selectedIndex;
            }
        }
    }
}