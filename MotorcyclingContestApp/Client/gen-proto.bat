set TOOLS_PATH=.\packages\Grpc.Tools.1.3.0\tools\windows_x86
set PROTO_DIR=C:\Users\marius\IdeaProjects\motorcycling-contest\server\src\main\proto
%TOOLS_PATH%\protoc.exe -I%PROTO_DIR% --csharp_out MotorcyclingContestApp\Client --grpc_out MotorcyclingContestApp\Client %PROTO_DIR%\motocontest.proto --plugin=protoc-gen-grpc=%TOOLS_PATH%\grpc_csharp_plugin.exe


