# LeagueLocaleLauncher [![Discord](https://img.shields.io/discord/713264229427445770?color=Blue&label=Join%20Us%20On%20Discord&style=plastic)](https://discord.gg/vA4w7rn) [![Build status](https://ci.appveyor.com/api/projects/status/5btl6k5d8tae4gk6?svg=true)](https://ci.appveyor.com/project/CollinMcKinney/leaguelocalelauncher)


A simple application that launches the League Of Legends launcher, with any Region &amp; Language combo (ex. Japanese on the NA server)

![Image description](https://i.imgur.com/c8bhvj4.png)

# Building From Source
* Building from source is for code tinkerers, if you just want to use the launcher and not worry about the code, jump to the **Usage Guide**.
* The current default branch is "master-ts" - this is a W.I.P. cross-platform TypeScript conversion. Likely to be many build issues and missing functions for a while. Currently using yarn/npm from Visual Studio Code for building.
* The previous release binaries are built off of the "old-cs" branch and this should be the branch you choose if you want to build the latest release yourself. Build with Visual Studio 2019.

# Usage guide

* (1) Make sure you have the latest release from https://github.com/CollinMcKinney-jabukufo/LeagueLocaleLauncher/releases ***THIS IS A DIFFERENT LINK THAN THE GREEN CLONE/DOWNLOAD BUTTON***


* (2) Start **LeagueLocaleLauncher.exe**, choose the language/region you wish to use and then click the launch button. The tool should close and then League Of Legends should be launched using the language and region you selected. If that worked, then congratulations, you're done :D


* (3) If something isn't working right:
  * (a) Go to **config.yaml** which should be located next to your .exe (it won't exist until you run the launcher the first time).
  * (b) Change **LeagueClientSettingsPath** and **LeagueClientPath** to match the file paths in your League Of Legends install.
  * (c) Repeat step 2.
  * (d) If it still doesn't work, either leave an issue here on GitHub, or [![Discord](https://img.shields.io/discord/713264229427445770?color=Blue&label=Join%20Us%20On%20Discord&style=plastic)](https://discord.gg/vA4w7rn) and we'll be glad to help you.
