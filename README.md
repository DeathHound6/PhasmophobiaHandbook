# Phasmophobia Handbook
A handbook guide application for the horror game Phasmophobia.

This app is designed to contain as much organised information about Phasmophobia as possible in order to help people to learn the game.

## Building Manually
It is recommended to only build the repo from a release commit to ensure that usage of the app is stable.
### PreRequisites
- [.NET Framework 4.7.1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net471-developer-pack-offline-installer)
- [Visual Studio 2017 (Minimum Version)](https://my.visualstudio.com/Downloads?q=visual%20studio%202017&wt.mc_id=o~msft~vscom~older-downloads) (Optional)

### Building
- [Clone the repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)
- With Visual Studio
	- Open the repository's `PhasmophobiaHandbook.sln` file using Visual Studio (File -> Open -> Project/Solution -> Select the .sln file)
	- At the top of the screen, there will be 2 dropdown boxes. For the first one, ensure that the value of the first is set to `Release`
	- Click on the `Build` button at the top, and select either `Build Solution` or `Rebuild Solution`
	- The built app is now available at `<RepositoryFolder>\PhasmophobiaHandbook\bin\Release\PhasmophobiaHandbook.exe`
- Without Visual Studio
	- Using the command line, use the `cd` command to enter the repository folder
	- Run `dotnet build -f net471 -o .\PhasmophobiaHandbook\bin\Release -c Release`
	- The built app is now available at `<RepositoryFolder>\PhasmophobiaHandbook\bin\Release\PhasmophobiaHandbook.exe`

## Downloading prebuilt app
- All prebuilt versions of the app are available at [the repository releases](https://github.com/DeathHound6/PhasmophobiaHandbook/releases)