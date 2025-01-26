# G-Helper——轻量级的华硕笔记本控制中心
[![United24](https://raw.githubusercontent.com/seerge/g-helper/main/docs/ua.png)](https://u24.gov.ua/)
[![GitHub release](https://img.shields.io/github/release/seerge/g-helper)](https://GitHub.com/seerge/g-helper/releases/) 
[![Github all releases](https://img.shields.io/github/downloads/seerge/g-helper/total)](https://GitHub.com/seerge/g-helper/releases/) [![GitHub stars](https://img.shields.io/github/stars/seerge/g-helper.svg?style=social)](https://GitHub.com/seerge/g-helper/stargazers/) 


语言: [English](https://github.com/seerge/g-helper#readme) | 中文 | [日本語](https://github.com/seerge/g-helper/blob/main/docs/README.ja-JP.md)

适用于华硕（Asus）笔记本电脑的轻量级 Armoury Crate (奥创控制中心)替代品，在功能几乎相同的同时减少不必要的服务以减轻负载。
G-helper兼容所有主流型号，例如 ROG 幻14、幻15、幻16、幻13、幻X、天选（飞行堡垒）系列、枪神/魔霸系列、创系列、灵耀系列、无畏系列、ROG Ally 等！

<table>
<tr>
   <td><b>支持此项目</b></td>
   <td >
      <a href="https://bit.ly/4c0ZWs9"><img src="https://raw.githubusercontent.com/seerge/g-helper/main/docs/paypal.png" height="36" alt="PayPal"></a>&nbsp;
      <a href="https://buy.stripe.com/bIY4hl8HbalH3G8bIJ"><img src="https://raw.githubusercontent.com/seerge/g-helper/main/docs/stripe.png" height="36" alt="Stripe"></a>&nbsp;
      <a href="https://buy.stripe.com/bIY4hl8HbalH3G8bIJ"><img src="https://raw.githubusercontent.com/seerge/g-helper/main/docs/alipay.png" height="36" alt="Alipay"></a>
   </td>
</tr>
</table>

### [:floppy_disk:下载应用](https://github.com/seerge/g-helper/releases/latest/download/GHelper.zip)

### [安装步骤](#安装指南)

### [常见问题解答(FAQ)](#常见问题解答)

### [更多自定义设置](#高级用户设置)

如果你喜欢这个应用，请[给这个项目⭐️](https://github.com/seerge/g-helper) 或者向别人推荐它！

[![G-Helper Download](https://github.com/pasical/g-helper/assets/112304778/03f442b9-29e8-4e99-a095-8eaa533c995b)](https://github.com/seerge/g-helper/releases/latest/download/GHelper.zip)

_如果你在别的地方提到这个软件，请记得加上这个项目的网址。十分感谢。_

## 🎁 主要优点

1. 自动且无缝的独立显卡模式切换(不需要关闭所有应用或执行其他操作)
2. 可以手动调整所有的性能模式(包括自定义风扇曲线以及PPTs(Platform Power Threshold,即CPU总功耗,下文简称PPTs ——译注))
3. 极致的轻量化，几乎不消耗任何资源，也不需要安装系统服务。只需要下载一个exe文件就可以运行。
4. 简洁的界面设计，可以轻松调整所有设置。
5. FN 锁定和自定义热键

![image](https://github.com/pasical/g-helper/assets/112304778/ee221865-cf36-4246-95f0-47313e647230)



### ⚡️ 主要功能

1. **性能模式**: 静音模式 - 平衡模式 - 增强模式 (笔电bios内置的性能模式，附带默认的风扇曲线)
2. **显卡模式**: 集显模式 - 标准模式 - 独显直连 - 自动切换
3. 笔记本屏幕刷新率 60hz 或 120hz 自动调节(或者 144hz 等刷新率)，包括屏幕Overdrive(OD,即ROG系列的屏幕快速响应/快显功能--译注)功能
4. 可调节的风扇曲线、电源功耗设置(PPTs)(_注:请谨慎调节!_)和CPU超频选项
5. ROG Anime matrix 光显矩阵屏控制， 感谢项目 [Starlight](https://github.com/vddCore/Starlight) + 应用侧的一些调整，包括动画GIF图片
6. 键盘灯光效果和颜色设置 (包括睡眠模式下的灯光效果和对飞行堡垒/天选系列的键盘支持)
7. 对M按键的自定义设置和 FN+X 快捷键的自定义
8. CPU/GPU温度、风扇转速和电池充放电功率显示
9. 电池充电上限设置，保护电池健康度
10. Nvidia GPU 超频和降压
11. XG Mobile 控制
12. AMD CPU 的降压
13. BIOS和驱动的升级
14. 华硕鼠标的配置修改
15. Mini-LED 屏幕的多区调光
16. 低亮度防闪烁功能和显示风格的修改

### ⚙️ 当使用电池供电或插上电源时，自动切换：

- 性能模式 (软件会记住上一次使用电池或插上电源时的电源模式)
- 自动切换独立显卡模式 - 使用电池时停用独显，并在插上电源时重新启用
- 自动切换屏幕刷新率 (使用电池时切换为 60hz,插入电源后切换为 120+ hz)
- 使用电池时键盘背光可自动关闭

_为了保证自动切换功能和按键绑定功能的正常工作，软件需要在后台运行并显示一个托盘图标。这并不会消耗其他资源。_

### 🚀 性能模式

_性能模式与 Armoury Crate(奥创控制中心)中的 **保持一致**，因为这些设置与其对应的风扇曲线都被保存在bios中_

1. 静音 (风扇转速最小或完全停转, 70W 总PPT, 其中 CPU 最高 45W PPT) + windows电源模式设置为最长续航/省电模式
2. 平衡/性能 (平衡模式的风扇曲线设置, 100W 总PPT, 其中 CPU 最高 45W PPT) + windows电源模式设置为平衡
3. 增强 (激进的风扇曲线设置, 125W 总PPT, 其中 CPU 最高 80W PPT) + windows电源模式设置为高性能/最佳性能

_PPTs 默认在 幻14 2022版上显示, 对于其他型号 PPTs 的显示将会有所变化，因为它们在bios中的设置不同。_

![Screenshot 2023-04-06 142234](https://user-images.githubusercontent.com/5920850/230377635-7032a480-3a94-4e35-9468-d8911e3e55ec.png)

### 🎮 显卡模式

1. 集显模式 : 只启用低功耗的内置显卡, 核显连接笔电内置屏幕
2. 标准模式 (MS Hybrid) : 同时启用核显与独显, 核显连接笔电内置屏幕
3. 独显直连: 同时启用核显与独显, 但独显直连笔电屏幕 (仅在幻14 2022版等机型上支持)
4. 自动切换: 使用电池时关闭独显(集显模式)，并在插上电源后重新启用独显(混合输出)

![Screenshot 2024-03-11 111818](https://github.com/seerge/g-helper/assets/5920850/fd69a81e-978d-4d5c-a0a8-26da51f90a5b)

![GPU Modes](https://github.com/seerge/g-helper/assets/5920850/65c6bdd5-728c-4965-b544-fcf5a85ed6a2)

### :mouse: 华硕鼠标和其他外设的支持

[目前支持的型号](https://github.com/seerge/g-helper/discussions/900)

_*对于中国大陆发行的版本仅供参考_
- ROG Chakram X (P708)
- ROG Chakram Core (P511)
- ROG Gladius II and Gladius II Origin (P502 and P504)
- ROG Gladius III
- ROG Gladius III Wireless
- ROG Harpe Ace Aim Lab Edition
- ROG Keris Wireless
- ROG Strix Carry (P508)
- ROG Strix III Gladius III Aimpoint Wireless (P711)
- ROG Strix Impact III (P518)
- ROG Spatha
- ROG Strix Impact II Wireless
- TUF Gaming M4 Wireless (P306)
- TUF Gaming M3
- TUF Gaming M3 Gen II

特别感谢 [@IceStormNG](https://github.com/IceStormNG) 👑 的贡献和研究！

### ⌨️ 按键绑定

- ``Fn + F5 / Fn + Shift + F5`` - 向前/向后切换性能模式
- ``Ctrl + Shift + F5 / Ctrl + Shift + Alt + F5`` - 向前/向后切换性能模式
- ``Ctrl + Shift + F12`` - 打开G-Helper窗口
- ``Ctrl + M1 / M2`` - 屏幕亮度调低/调高
- ``Shift + M1 / M2`` - 键盘背光亮度调低/调高
- ``Fn + C`` - Fn锁定
- ``Fn + Shift + F7 / F8`` - 光显矩阵/光线矩阵亮度调低/调高
- ``Fn + Shift + F7 / F8`` - 屏幕亮度调低/调高
- ``Ctrl + Shift + F20`` - 麦克风静音
- ``Ctrl + Shift + Alt + F14`` - 集显模式
- ``Ctrl + Shift + Alt + F15`` - 标准模式
- ``Ctrl + Shift + Alt + F16`` - 静音模式
- ``Ctrl + Shift + Alt + F17`` - 平衡模式
- ``Ctrl + Shift + Alt + F18`` - 增强模式
- ``Ctrl + Shift + Alt + F19`` - 自定义 1（如果存在）
- ``Ctrl + Shift + Alt + F20`` - 自定义 2（如果存在）
- [自定义键绑定/热键](https://github.com/seerge/g-helper/wiki/Power-user-settings#custom-hotkey-actions)

### 🎮ROG Ally 按键
- ``M + DPad Left / Right`` - 显示亮度
- ``M + DPad Up`` - 屏幕键盘
- ``M + DPad Down`` - 显示桌面
- ``M + Y`` - 切换 AMD 覆盖
- ``M + X`` - 截屏
- ``M + Right Stick Click`` - 控制器模式

------------------
#### 如果您喜欢本项目，可以扫描以下二维码捐赠 

| [Paypal in EUR](https://www.paypal.com/donate/?hosted_button_id=4HMSHS4EBQWTA) | [Paypal in USD](https://www.paypal.com/donate/?hosted_button_id=SRM6QUX6ACXDY) |
| ------------------------------------------ | ----------------------------------------------- |
| [![QR Code](https://user-images.githubusercontent.com/5920850/233658717-0441494d-fede-4a2c-b4f2-4b16a184a69a.png)](https://www.paypal.com/donate/?hosted_button_id=4HMSHS4EBQWTA) | [![QR Code](https://github-production-user-asset-6210df.s3.amazonaws.com/5920850/239492811-b487e89a-3df6-42ea-bdb8-24c455ab2310.png)](https://www.paypal.com/donate/?hosted_button_id=SRM6QUX6ACXDY) |

------------------

# 常见问题解答

_*由于译者精力有限，以下的解答可能过时/未收录最新的问题，如有需要请自行查看英文版README或者issue列表_

#### 当我按下 M4 / Rog键的时候总是弹出安装Armoury Crate的弹窗提示，我该如何关闭它?

- 删除下列文件或者把它移动(注:剪切+粘贴)到别的目录 ``C:\Windows\System32\ASUSACCI\ArmouryCrateKeyControl.exe``.

- 如果还是出现弹窗 - 进入 BIOS (开机时按住 F2), 按照屏幕下方的快捷键提示进入 Advanced Settings,然后关闭 "Armoury Crate Control Interface" (注:把它设置为disabled)。

#### 电池充电限制不起作用

- 这有可能是因为ASUS服务在你设置后又覆写了对应的设置。你可以通过在G-helper中点击"更多"，然后在"正在运行的Asus服务项"右侧点击"停止"来停止ASUS服务。

#### 我没看到显卡模式

- 在一些旧型号中(比如幻14 2020)从硬件层上不支持禁用显卡，在这些机型中并不需要显卡模式，因此没有显示。

#### 为什么我的电脑上没有独显直连

- 独显直连(在硬件层面上)只对2022年之后的机型中生效。

#### 我是否应该自行调整功耗设置(PPTs)和风扇曲线?

- 你可以不那么做，这些操作是可选的。按照经验(bios)内置的性能模式工作的很好。请只在遇到问题的时候限制功耗或者手动设置风扇模式。当你在风扇与功率设置中按下“应用”时，bios将会认为风扇配置文件为“自定义”! (无论你是否真的修改了风扇曲线)

#### G-helper是如何控制我的风扇转速的?

- 软件并不会修改风扇转速。这个设置实际上由bios控制(与Armoury Crate的情况相同)。G-helper 所能做的 - 就是将一个自定义的风扇配置(可选地)应用到正在使用的性能模式，其中包括8组温度+风扇速度的百分比数值%。软件通过与Armoury Crate看起来相同的WMI endpoint来应用这一设置，

#### 我如何把风扇转速显示从百分比%切换到RPM(每分钟转速)?

- 点击一下百分比即可切换。

#### 当我修改自定义风扇曲线时，我得到了"BIOS拒绝修改风扇曲线"("BIOS rejected fan curve")提示

- 2021之后的TUF机型不支持自定义风扇曲线。很可能在Armory Crate中也没有这个选项。

#### 我没有在G-helper中看到独显温度

- 很可能要么你正在使用核显模式/自动切换模式，这种情况下独显只是关闭了；或者你的windows系统为独显设置了睡眠模式(为了省电)。这种情况下，G-helper无法识别到独显，也不能获得温度读数。

#### 打开应用后没有看到应用启动/弹窗提示"G-Helper已经在运行"

- 请在系统托盘里找到 (G) 图标。windows会默认隐藏所有图标，所以你可能需要点击 ^ 来看见它们。建议任务栏右键进入任务栏设置 → 其他系统图标 → 将 G-Helper 设置为始终在任务栏上显示。

#### 应用不能启动或者崩溃了，我该怎么做?

- 从开始菜单里打开“事件管理器”， 进入 Windows日志 -> 应用，然后在最近的错误日志里寻找包含 G-helper 的日志。如果你找到一个 - 请提出一个 [新的 issue](https://github.com/seerge/g-helper/issues) ，其中包含来自这次错误的所有的详细信息。

#### 我可以在用G-Helper的时候同时用myASUS吗?

- 当然可以! 唯一的问题是myASUS可能会重置你之前在 G-helper 里设置的电池充电上限。在这种情况下，建议你在这两个应用(myASUS和g-helper)里设置相同的充电上限(60%/80%/100%)以避免冲突。

#### 我如何将M3键设置为将麦克风静音?

- 这个功能由 Asus Optimization Service 管理(所以 G-helper 没有这项设置，也不管理这个功能)。请确认这个系统服务是否正常运行

#### 我如何设置不同的视觉风格(即 Armoury Crate 内的gamevisual功能)?

- 因为这个功能让颜色显示不正确，我个人（译注:指作者 :) ）并不喜欢这些。但是如果你需要这个功能 - 你可以使用 Nvidia 控制面板/GefoeceExperirence滤镜或者AMD控制面板(Radeon Software/AMD Software: Adrenalin Edition)来修改显示颜色(因显示器和配置而异)。如果你真的非常需要这个功能，你也可以使用 [微软商店中ASUS自己的工具](https://apps.microsoft.com/store/detail/gamevisual/9P4K1LFTXSH8?hl=nl-nl&gl=nl&rtc=1)

#### 我能超频 Nvidia GPU 核心或显存吗?

- 首先确保你的独立显卡是启用的，之后打开"风扇 + 电源"选项，在这里即可调整核心和显存频率。这个和Armoury Crate中的设置一样。注意，使用这项功能需要管理员权限，应用也会弹出需要管理员权限的提示。(*)

#### Windows Defender将该应用标记为恶意软件/病毒

- 这是Windows Defender的误报(其他使用机器学习来检测病毒的杀毒软件可能也出现同样的结果)，这可能是因为本应用没有数字签名和证书。如果你不放心的话，你可以自己编译安装本项目，本项目是完全开源的。

#### 我该在哪找到应用的配置文件和日志文件

- 你可以在 `%AppData%\GHelper` 文件夹找到他们，当你在issue中提交bug的时候，请务必附上应用日志。

#### 应用无法在开机时启动或者启动的时候在任务栏没有提示

- 打开应用，取消再重新勾选"开机自启"项目。如果还是不行的话，你可以手动在Windows 任务计划程序(Task Scheduler)中为G-helper应用增加几秒延迟后再启动。

#### 我该如何卸载G-helper?

- G-helper是一个单文件的exe文件, 而且它不会向系统中安装任何东西。如果要“卸载”它 - 你可以直接删除exe文件 :) 如果你已经设置了自定义的风扇配置或者功耗设置(PPTs) - 在删除软件之前建议你选择你最喜欢的配置模式(比如"平衡")，然后在“风扇与电源设置”里点击“恢复默认设置”。

#### 我如何给我的CPU降压？

- 目前你只能给AMD CPU降压。如果你的机型支持这个功能 - 你会在“风扇 + 电源”项中看到对应的设置。如果你看不到该项设置，说明你的CPU不支持降压。所有支持的型号可以[点此查询](https://github.com/seerge/g-helper/discussions/736)。

#### 我的机型是幻14 2023并且我无法关闭/开启我的独立显卡

- 这应该是旧版本的BIOS的问题。根据[用户反馈](https://github.com/seerge/g-helper/issues/680)，更新最近的BIOS 312版本即可解决问题(可以通过MyASUS或者G-helper "更新" 项进行安装)。

#### 我的机型是幻15 2022并且我无法关闭/开启我的独立显卡或者风扇出问题

- 幻15 2022款在BIOS 313以上版本会有很多小问题。许多用户反馈可以通过[将BIOS版本降级到311版本来解决](https://rog.asus.com/nl/laptops/rog-zephyrus/rog-zephyrus-g15-2022-series/helpdesk_bios/)。

#### 我删除了Armoury之后我的GPU性能降低了

- 检查你的 Nvidia Experience 设置，确保Whisper Mode项是关闭的。你还可以尝试重置所有设置。`Nvidia 控制面板 → 管理 3D  设置 → 恢复`

#### 我如何从硬件层面重启我的笔记本？

- 所有的华硕笔记本都支持方便的硬重启。它不会影响你的数据，但是会重置所有硬件相关的东西(例如启动独立显卡，唤醒wifi/蓝牙模块等)
- 关闭你的电脑，长按“电源”按钮30-40秒。之后正常启动你的电脑(会比正常情况下花更长时间启动)。

#### G-helper 是什么?

- 这是一个轻量化的Armoury Crate(奥创控制中心)替代工具，而且不需要任何多余的功能或安装不必要的系统服务的。在ROG G14, G15, G16, M16, X13, Z13, X16, TUF, Scar, Vivobook, ProArt等热门笔记本中都适用。

------------------

# 安装指南

### 如何开始

1. 下载[**最新版本**](https://github.com/seerge/g-helper/releases/latest/download/GHelper.zip)

2. 解压到您选择的文件夹 _（不要直接从zip运行exe，因为Windows会将其放入临时文件夹并在之后删除）_

3. 运行**GHelper.exe**

- 如果您在启动时收到来自 Windows Defender 的警告（Windows 保护了您的电脑）。
单击“更多信息”→“仍然运行”。
- 如果出现“在商店中搜索应用程序”对话框，则这是 Windows Defender 的一个错误。
右键单击 GHelper.exe → 选择“属性” → 选择“取消阻止复选框”

### 要求（强制）

- [Microsoft .NET 7](https://download.visualstudio.microsoft.com/download/pr/8091a826-e1c4-424a-b17b-5c10776cd3de/8957f21a279322d8fac9b542c6aba12e/dotnet-sdk-7.0.408-win-x64.exe)
- [华硕系统控制界面](https://dlcdnets.asus.com/pub/ASUS/nb/Image/CustomComponent/ASUSSystemControlInterfaceV3/ASUSSystemControlInterfaceV3.exe)

### 建议（可选）

- **不建议**将该应用程序与 Armoury Crate 服务结合使用，因为它们调整相同的设置。 您可以[使用AC自带的卸载工具卸载](https://dlcdnets.asus.com/pub/ASUS/mb/14Utilities/Armoury_Crate_Uninstall_Tool.zip?model=armoury%20crate)。 以防万一，您可以稍后再安装它。
- **不建议**运行“ASUS Smart Display Control”应用程序，因为它会尝试更改刷新率并与 G-helper 争夺相同的功能。 您可以安全地卸载它。
- 如果您不打算使用 MyASUS，您可以停止/禁用不必要的服务：转到应用程序中的 **Extra**，然后按 Asus 服务部分中的“停止”。 要重新启动/启用服务 - 单击“开始”。


---

精简你的windows可以帮助延长电池的使用时间，同时让笔电的温度更低一些

![Helps to save your battery](https://raw.githubusercontent.com/seerge/g-helper/main/docs/screenshots/screen-5w.png)

---

# 高级用户设置

### 为每一个模式自定义用户计划

在 config.json (位于 %appdata/GHelper) 中你可以手动添加自定义电源设置的GUID (它既可以是"真正的"可被选择的电源计划，也可以是"覆盖式(overlay)"的电源计划，就像g-helper默认设置的那样)

格式如下 : "scheme_`<mode>`" : "GUID"

Where ``mode = 0 (balanced), 1 (turbo), 2 (silent)``

```
"scheme_0": "2ac1d0e0-17a7-44ed-8091-d88ef75a4eb0",
"scheme_1": "381b4222-f694-41f0-9685-ff5bb260df2e"
```

确保修改时保证json文件的结构不被打乱 (例如不要增减或缺失逗号、括号等操作) - 否则应用会读取失败，并将重新创建一个新的配置文件来替代它。

### 自定义热键行为

软件支持热键自定义配置。如要设置，在按键旁的选项框中选择"自定义设置"，然后执行下面的操作(任选其一):

1. 要想运行任意应用 - 向 "action" 文本框中粘贴应用文件exe的完整路径，例如:
   ``C:\Program Files\EA Games\Battlefield 2042\BF2042.exe``
2. 要想模拟任意windows按键 - 向"action"文本框中粘贴相对应的 keycode，例如 ``0x2C`` 为屏幕截图键。
   Keycodes的完整列表: https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes

![image](https://github.com/pasical/g-helper/assets/112304778/1280b7c9-f0c1-4b91-b502-2b9dd79b12d8)



---

### 使用的库和项目
- [Linux Kernel](https://github.com/torvalds/linux/blob/master/drivers/platform/x86/asus-wmi.c)华硕 ACPI/WMI 接口中一些基本端点的 Linux 内核 
- [NvAPIWrapper](https://github.com/falahati/NvAPIWrapper) 用于访问 Nvidia API
- [Starlight](https://github.com/vddCore/Starlight) 光显矩阵通信协议
- [UXTU](https://github.com/JamesCJ60/Universal-x86-Tuning-Utility) 使用 Ryzen 系统管理单元进行降压
- [AsusCtl](https://gitlab.com/asus-linux/asusctl) 提供灵感和一些逆向工程

### 🔖 注意事项

G-Helper 不是操作系统、固件或驱动程序。它无论如何都不会实时“运行”您的硬件。

这只是一个应用程序，允许您选择制造商创建的预定义操作模式之一（并存储在 BIOS 中），并可选地（！）设置一些已经存在于您的设备上的设置，与 Armoury Crate 的原理相同。它通过使用 Armoury Crate 所使用的 Asus System Control Interface “驱动程序”来实现所有功能。

如果您使用的模式/设置与 Armoury Crate 中的相同 - 您设备的性能或行为不会有差异。

G-Helper 对您笔记本电脑的作用，类似于遥控器对您电视的作用。

### 免责声明

"ROG"、"TUF" 和 "Armoury Crate" 是 AsusTek Computer, Inc. 的注册商标。我对这些或任何属于 AsusTek Computer 的资产不提出任何主张，仅出于信息传递目的而使用它们。

软件按“现状”提供，不提供任何形式的明示或暗示保证，包括但不限于对适销性、特定用途的适用性和非侵权的保证。滥用此软件可能导致系统不稳定或故障。

_注:请务必参考下方 **免责声明** 原文，以避免或减小错误或不恰当之翻译引起的负面影响。翻译仅为便于阅读之目的，并非专业翻译，可能存在错误，可能与最新版本有所差异。本文不具有法律效力，亦不作为发生争端时处理之依据。_

**Disclaimers**
"ROG", "TUF", and "Armoury Crate" are trademarked by and belong to AsusTek Computer, Inc. I make no claims to these or any assets belonging to AsusTek Computer and use them purely for informational purposes only.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. MISUSE OF THIS SOFTWARE COULD CAUSE SYSTEM INSTABILITY OR MALFUNCTION.
