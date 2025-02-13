# G-Helper - Lightweight control tool for Asus laptops
[![United24](https://raw.githubusercontent.com/seerge/g-helper/main/docs/ua.png)](https://u24.gov.ua/)
[![GitHub release](https://img.shields.io/github/release/seerge/g-helper)](https://GitHub.com/seerge/g-helper/releases/) 
[![Github all releases](https://img.shields.io/github/downloads/seerge/g-helper/total)](https://GitHub.com/seerge/g-helper/releases/) [![GitHub stars](https://img.shields.io/github/stars/seerge/g-helper.svg?style=social)](https://GitHub.com/seerge/g-helper/stargazers/) <sup>[中文版点这里](https://github.com/seerge/g-helper/blob/main/docs/README.zh-CN.md)</sup> <sup>[日本語はこちら](https://github.com/seerge/g-helper/blob/main/docs/README.ja-JP.md)</sup>

Small and lightweight Armoury Crate alternative for Asus laptops offering almost same functionality with a much smaller footprint. Works with all popular models, such as ROG Zephyrus G14, G15, G16, M16, Flow X13, Flow X16, Flow Z13, DUO, TUF Series, Strix or Scar Series, ProArt, Vivobook, Zenbook, ROG Ally or Ally X and many more! 

# [:floppy_disk: Download](https://github.com/seerge/g-helper/releases/latest/download/GHelper.zip)
**⭐ If you like the app - please spread the word about it online**

<table>
<tr>
   <td><b>Support Project</b></td>
   <td >
      <a href="https://bit.ly/4c0ZWs9"><img src="https://raw.githubusercontent.com/seerge/g-helper/main/docs/paypal-eur.png" height="36" alt="PayPal EUR"></a>&nbsp;
      <a href="https://bit.ly/4aGTyW8"><img src="https://raw.githubusercontent.com/seerge/g-helper/main/docs/paypal-usd.png" height="36" alt="PayPal USD"></a>&nbsp;
      <a href="https://buy.stripe.com/8wM6pt8HbgK50tWbIK"><img src="https://raw.githubusercontent.com/seerge/g-helper/main/docs/stripe.png" height="36" alt="Stripe"></a>&nbsp;
      <a href="https://buy.stripe.com/6oE29dg9D3Xj7Wo28b"><img src="https://raw.githubusercontent.com/seerge/g-helper/main/docs/alipay.png" height="36" alt="Alipay"></a>
   </td>
</tr>
</table>

> or use a package manager\
> [Chocolatey](https://community.chocolatey.org/packages/g-helper): `choco install g-helper`

- [FAQ](https://github.com/seerge/g-helper/wiki/FAQ)
- [Setup and Requirements](https://github.com/seerge/g-helper/wiki/Requirements)
- [Troubleshooting](https://github.com/seerge/g-helper/wiki/Troubleshooting)
- [Power User Settings](https://github.com/seerge/g-helper/wiki/Power-user-settings)


[![G-Helper Download](https://github.com/seerge/g-helper/assets/5920850/4d98465a-63a5-4498-ae14-afb3e67e7e82)](https://github.com/seerge/g-helper/releases/latest/download/GHelper.zip)

## :loudspeaker: YouTube Reviews and Guides
| [![Youtube review Josh Cravey](https://i.ytimg.com/vi/hqe-PjuE-K8/hqdefault.jpg)](https://www.youtube.com/watch?v=hqe-PjuE-K8) | [![Youtube review cbutters Tech](https://i.ytimg.com/vi/6aVdwJKZSSc/hqdefault.jpg)](https://www.youtube.com/watch?v=6aVdwJKZSSc) |
| ----------------- | ---------------- | 
| [Josh Cravey](https://www.youtube.com/watch?v=hqe-PjuE-K8) | [cbutters Tech](https://www.youtube.com/watch?v=6aVdwJKZSSc) | 

## 📰 Articles
1. https://www.digitaltrends.com/computing/g-helper-armoury-crate-alternative/
2. https://binaryfork.com/ghelper-armoury-crate-alternative-10216/

## :gift: Advantages 

1. Seamless and automatic GPU switching
2. All performance modes can be fully customized with power limits and fan curves
3. Lightweight. Doesn't install anything in your system. Just a single exe to run
4. Simple and clean native UI with easy access to all settings
5. FN-Lock and custom hotkeys

![Screenshot 2024-03-11 104354](https://github.com/seerge/g-helper/assets/5920850/626a5a6e-fdae-431c-843e-92886c8420ee)

### :zap: Features

1. Performance modes: Silent - Balanced - Turbo (built-in, with default fan curves)
2. GPU modes: Eco - Standard - Ultimate - Optimized
3. Screen refresh rate control with display overdrive (OD) 
4. Custom fan curve editor, power limits and turbo boost selection for every performance mode
5. Anime Matrix or Slash Lighting control including animated GIFs, clock and Audio visualizer
6. Backlight animation modes and colors 
7. Hotkey handling
8. Monitor CPU and GPU temperature, fan speeds and battery status
9. Battery charge limit to preserve battery health
10. NVidia GPU overclocking and undervolting
11. XG Mobile Control
12. AMD CPU Undervolting
13. BIOS and Driver Updates
14. Asus Mice settings
15. Mini-led multi-zone switch
16. Flicker-free dimming and Visual Modes

### :gear: Automation
- Performance Mode switching when on battery or plugged in
- Optimized GPU mode - disables dGPU on battery and enables when plugged in
- Auto Screen refresh rate (60Hz on battery and max Hz when plugged)
- Keyboard backlight timeout on battery or when plugged in

### :rocket: Performance Modes

<img align="right" width="300" src="https://github.com/seerge/g-helper/assets/5920850/3e119674-db8d-486b-aa65-2bf9b61f9aa6">

All Modes are **baked in BIOS** along with default fan curves and power limits and they are the **same** as in the Armoury Crate.

Each BIOS mode is paired with matching Windows Power Mode. You can adjust this setting under ``Fans + Power``

1. **Silent** in BIOS + **Best power efficiency** power mode
2. **Balanced** (Performance in AC) in BIOS  + **Balanced** power mode
3. **Turbo** in BIOS + **Best performance** power mode
   

### :video_game: GPU Modes

1. **Eco** : only low power integrated GPU enabled, iGPU drives built in display
2. **Standard** (MS Hybrid) : iGPU and dGPU enabled, iGPU drives built in display
3. **Ultimate**: iGPU and dGPU enabled, but dGPU drives built in display (supported on 2022+ models)
4. **Optimized**: disables dGPU on battery (Eco) and enables when plugged in (Standard)

![Screenshot 2024-03-11 111818](https://github.com/seerge/g-helper/assets/5920850/fd69a81e-978d-4d5c-a0a8-26da51f90a5b)

![GPU Modes](https://github.com/seerge/g-helper/assets/5920850/65c6bdd5-728c-4965-b544-fcf5a85ed6a2)


### :mouse: Asus Mouse and other peripherals support

[Currently supported models](https://github.com/seerge/g-helper/discussions/900)
- ROG Chakram X (P708)
- ROG Chakram Core (P511)
- ROG Gladius II and Gladius II Origin (P502 and P504)
- ROG Gladius II Wireless
- ROG Gladius III
- ROG Gladius III Wireless
- ROG Harpe Ace Aim Lab Edition
- ROG Keris Wireless
- ROG Keris II Ace
- ROG Strix Carry (P508)
- ROG Strix III Gladius III Aimpoint Wireless (P711)
- ROG Strix Impact III (P518)
- ROG Spatha X
- ROG Strix Impact II Wireless
- ROG Pugio
- ROG Pugio II
- TUF Gaming M4 Wireless (P306)
- TUF Gaming M3
- TUF Gaming M3 Gen II
- TUF Gaming M4 AIR
- TUF Gaming M5
- TX Gaming Mini

Huge thanks to [@IceStormNG](https://github.com/IceStormNG) 👑 for contribution and research (!).

### ⌨️ Keybindings

- ``Fn + F5 / Fn + Shift + F5`` - Toggle Performance Modes forwards / backwards
- ``Ctrl + Shift + F5 / Ctrl + Shift + Alt + F5`` - Toggle Performance Modes forwards / backwards
- ``Ctrl + Shift + F12`` - Open G-Helper window
- ``Ctrl + M1 / M2`` - Screen brightness Down / Up
- ``Shift + M1 / M2`` - Backlight brightness Down / Up
- ``Fn + C`` - Fn-Lock
- ``Fn + Ctrl +  F7 / F8`` - Flicker-free dimming Down / Up
- ``Fn + Shift + F7 / F8`` - Matrix / Slash Lighting brightness Down / Up
- ``Fn + Shift + F7 / F8`` - Screenpad brightness Down / Up
- ``Ctrl + Shift + F20`` - Mute Microphone
- ``Ctrl + Shift + Alt + F13`` - Toggle Display Refresh Rate
- ``Ctrl + Shift + Alt + F14`` - Eco GPU Mode
- ``Ctrl + Shift + Alt + F15`` - Standard GPU Mode
- ``Ctrl + Shift + Alt + F16`` - Silent
- ``Ctrl + Shift + Alt + F17`` - Balanced
- ``Ctrl + Shift + Alt + F18`` - Turbo
- ``Ctrl + Shift + Alt + F19`` - Custom 1 (if exists)
- ``Ctrl + Shift + Alt + F20`` - Custom 2 (if exists)
- [Custom keybindings / hotkeys](https://github.com/seerge/g-helper/wiki/Power-user-settings#custom-hotkey-actions)

### 🎮ROG Ally Bindings
- ``M + DPad Left / Right`` - Display Brightness
- ``M + DPad Up`` - Touch keyboard
- ``M + DPad Down`` - Show desktop
- ``M + Y`` - Toggle AMD overay
- ``M + X`` - Screenshot
- ``M + Right Stick Click`` - Controller Mode

------------------

### 🔖 Important Notice

G-Helper is **NOT** an operating system, firmware, or driver. It **DOES NOT** "run" your hardware in real-time anyhow. 

It's an app that lets you select one of the predefined operating modes created by manufacturer (and stored in BIOS) and optionally(!) set some settings that already exist on your device same as Armoury Crate can. It does it by using the Asus System Control Interface "driver" that Armoury uses for it.

If you use equivalent mode/settings as in Armoury Crate - the performance or the behavior of your device won't be different.

The role of G-Helper for your laptop is similar to the role of a remote control for your TV.

### Libraries and projects used
- [Linux Kernel](https://github.com/torvalds/linux/blob/master/include/linux/platform_data/x86/asus-wmi.h) for some basic endpoints in ASUS ACPI/WMI interface
- [NvAPIWrapper](https://github.com/falahati/NvAPIWrapper) for accessing Nvidia API
- [Starlight](https://github.com/vddCore/Starlight) for anime matrix communication protocol
- [UXTU](https://github.com/JamesCJ60/Universal-x86-Tuning-Utility) for undervolting using Ryzen System Management Unit
- [AsusCtl](https://gitlab.com/asus-linux/asusctl) for inspiration and some reverse engineering

### Disclaimers
"Asus", "ROG", "TUF", and "Armoury Crate" are trademarked by and belong to AsusTek Computer, Inc. I make no claims to these or any assets belonging to AsusTek Computer and use them purely for informational purposes only.

THE SOFTWARE IS PROVIDED “AS IS” AND WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. MISUSE OF THIS SOFTWARE COULD CAUSE SYSTEM INSTABILITY OR MALFUNCTION.
