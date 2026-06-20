![Static Badge](https://img.shields.io/badge/ManuHub.FFmpeg.Toolchain-blue) ![NuGet Version](https://img.shields.io/nuget/v/ManuHub.FFmpeg.Toolchain)  ![NuGet Downloads](https://img.shields.io/nuget/dt/ManuHub.FFmpeg.Toolchain)

# ManuHub.FFmpeg.Toolchain

`ManuHub.FFmpeg.Toolchain` is a lightweight, automated build-time utility that fetches the latest stable **FFmpeg**, **FFprobe**, and **FFplay** binaries directly from official sources during your .NET project build.

This package removes the need to manually manage binary dependencies or ship large NuGet packages. It ensures your application always has the latest tools available in your output directory exactly when you need them.

### ✨ Why the Toolchain Model?

* **Always Up-to-Date:** Fetches the latest stable builds directly from the BtbN FFmpeg build repository during the build process.
* **Zero-Bloat:** Your NuGet package size remains tiny because it doesn't bundle the actual binaries—it downloads them only when required for your specific build environment.
* **Seamless Integration:** Binaries are automatically placed in a `tools/` sub-directory within your build output (`bin/Debug` or `bin/Release`), ready for immediate execution.
* **CI/CD Friendly:** Perfect for automated pipelines, ensuring every build is equipped with the latest media processing capabilities.

### 📦 How it Works

When you build your project, the Toolchain:

1. **Checks** if the binaries already exist in your build environment.
2. **Downloads** the latest official zip archive from the FFmpeg master builds.
3. **Extracts** `ffmpeg.exe`, `ffprobe.exe`, and `ffplay.exe` into your project's output folder under the `/tools` directory.
4. **Cleans up** temporary extraction files automatically.

### 🚀 Usage

Once installed, the tools are automatically placed in `$(TargetDir)tools/`. You can reference them in your C# code as follows:

```csharp
using System.IO;
using System.Diagnostics;

// Path to your tools directory
string toolsFolder = Path.Combine(AppContext.BaseDirectory, "tools");
string ffmpegPath = Path.Combine(toolsFolder, "ffmpeg.exe");

var startInfo = new ProcessStartInfo(ffmpegPath, "-i input.mp4 output.mkv")
{
    UseShellExecute = false,
    CreateNoWindow = true
};

Process.Start(startInfo);

```

### 🔗 Ecosystem

* **ManuHub.Ytdlp** – Latest stable yt-dlp binary for video downloads.
* **Toolchain Logic** – Designed to complement media-heavy .NET applications requiring zero-setup dependencies.

### ⚠ Disclaimer

* This package does not host or modify FFmpeg binaries.
* FFmpeg is part of the FFmpeg project and is distributed under the terms of its respective license.
* All rights and licenses belong to the FFmpeg project and its contributors.

[Project website](https://ffmpeg.org/)
