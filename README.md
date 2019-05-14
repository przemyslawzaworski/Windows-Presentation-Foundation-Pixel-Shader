# Windows-Presentation-Foundation-Pixel-Shader

1. Open WpfApp1.sln
2. Repository contains simple framework for WPF pixel shaders.
3. Example shader renders procedural pattern with blue channel animated in time.
4. Compile HLSL shaders with fxc.exe (example location: "C:\Program Files (x86)\Windows Kits\10\bin\10.0.17763.0\x86")
5. Command line: fxc.exe /T ps_3_0 /E main /Fo "test.ps" "test.hlsl"
