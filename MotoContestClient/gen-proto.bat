setlocal

@rem enter this directory
cd /d %~dp0

set TOOLS_PATH=.\packages\Grpc.Tools.1.3.0\tools\windows_x64

set PROTO_DIR=C:\Users\marius\IdeaProjects\motorcycling-contest\server\src\main\proto

%TOOLS_PATH%\protoc.exe -I%PROTO_DIR% --csharp_out MotoContest --grpc_out MotoContest --plugin=protoc-gen-grpc=%TOOLS_PATH%\grpc_csharp_plugin.exe %PROTO_DIR%\motocontest.proto

endlocal
