Aura-Patcher
===========

A game patcher for Windows/PC games. Can patch huge files with small patch.

This page contains an installation and using guide

##Patcher

In root of builded patcher create folder 'patcher'. It must contain next files:
* configuration.xml - a patcher configuration file
* game_logo.png  - 248x338 game logo displayed at the form
* publisher_logo.png  - 248x112 publisher logo displayed at the form
* title_logo.png -  187x79 Title Logo at top.
* version.txt - file that contain 1 integer digit defining current version number

##configuration.xml


```
#!xml
<?xml version="1.0"?>
<root>
    <!-- used in form title -->
    <game_name>Aura-Project</game_name>
    <!-- launches when play button pressed -->
    <game_exe>client.exe</game_exe>
	<!-- The cliente Code -->
	<code>1622</code>
	<!-- Client Version -->
	<ver>102</ver>
	<!-- Login IP Server -->
	<logip>127.0.0.1</logip>
	<!-- Login IP Port -->
	<logport>11000</logport>
	<!-- Chat IP Server -->
	<chatip>127.0.0.1</chatip>
	<!-- Chat IP Port -->
	<chatport>8002</chatport>
	<!-- Features Settings -->
	<setting>"file://data/features.xml=Regular, USA"</setting>
    <!-- opens in default browser when game logo clicked-->
    <game_url>http://aura-project.org/</game_url>
    <!-- URL of file contains last version of game client-->
    <check_version_url>http://aura-project.org/launcher/version.txt</check_version_url>
    <!-- URL of directory contains patched-->
    <patches_directory>http://aura-project.org/launcher/patches/</patches_directory>
    <!-- URL with news page-->
    <news_url>http://aura-project.org/launcher/news_patcher.php</news_url>
    <!-- opens in default browser when publisher logo clicked-->
    <publisher_url>http://aura-project.org/</publisher_url>
</root>
```

##Patch builder

Create `source` directory in the root of patch builder. Place game clients in folders with name of it's version. Game clients must contains configured patcher with correct version.txt file matching with the index of folder (name).
For example:

![example](http://i.imgur.com/PS3veeS.png)


Run patch builder and select from which to which version build a patch. Step must be one, because patcher supports only incremental update.
Click "Make patch".
Result patch will be placed in output folder with name like 1_2.patch

P.S. You may place this patch to any web hosting (even Dropbox)
