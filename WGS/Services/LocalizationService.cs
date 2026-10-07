using CommunityToolkit.Mvvm.ComponentModel;

namespace WGS.Services;

public partial class LocalizationService : ObservableObject
{
    private static LocalizationService? _instance;
    public static LocalizationService Instance => _instance ??= new LocalizationService();

    // ── Window / Titlebar ──────────────────────────────────────────────
    public string AppTitle           => "Windows 游戏服务器";
    public string Running            => "运行中";
    public string Total              => "总数";

    // ── Sidebar ────────────────────────────────────────────────────────
    public string Servers            => "服务器";
    public string AddServer          => "+ 添加服务器";
    public string BackupAll          => "💾 全部备份";
    public string SettingsBtn        => "⚙ 设置";

    // ── Server header ──────────────────────────────────────────────────
    public string BtnStart           => "▶  启动";
    public string BtnStop            => "■  停止";
    public string BtnRestart         => "↺ 重启";
    public string BtnInstall         => "↓ 安装 / 更新";
    public string Uptime             => "运行时间";

    // ── Status ─────────────────────────────────────────────────────────
    public string StatusRunning      => "运行中";
    public string StatusStopped      => "已停止";
    public string StatusStarting     => "启动中...";
    public string StatusStopping     => "停止中...";
    public string StatusInstalling   => "安装中...";
    public string StatusUpdating     => "更新中...";
    public string StatusError        => "错误";
    public string StatusNotInstalled => "未安装";

    // ── Tabs ───────────────────────────────────────────────────────────
    public string TabConsole         => "控制台";
    public string TabSettings        => "设置";
    public string TabBackups         => "备份";
    public string TabInfo            => "信息";

    // ── Console ────────────────────────────────────────────────────────
    public string ConsolePlaceholder => "输入命令...";
    public string ConsoleSend        => "发送";
    public string ConsoleClear       => "清空";
    public string ConsoleFilter      => "筛选...";
    public string RconConnect        => "RCON：连接";
    public string RconDisconnect     => "RCON：断开";
    public string RconConnectedTxt   => "已连接";
    public string RconDisconnectedTxt => "已断开";

    // ── Settings tab ───────────────────────────────────────────────────
    public string SettingsTitle      => "服务器设置";
    public string SettingsGeneral    => "常规";
    public string SettingsAutomation => "自动化";
    public string SettingsFiles      => "文件与端口";
    public string FieldDisplayName   => "显示名称";
    public string FieldServerName    => "服务器名称（游戏内）";
    public string FieldIp            => "IP 地址";
    public string FieldPort          => "游戏端口";
    public string FieldQueryPort     => "查询端口";
    public string FieldMaxPlayers    => "最大玩家数";
    public string FieldPassword      => "密码";
    public string FieldRconPort      => "RCON 端口";
    public string FieldRconPassword  => "RCON 密码";
    public string FieldExtraArgs     => "额外参数";
    public string FieldInstallPath   => "安装目录";
    public string CheckAutoRestart   => "崩溃后自动重启";
    public string CheckAutoUpdate    => "启动时自动更新";
    public string BtnCheckPorts      => "🔍  检查端口";
    public string BtnOpenFolder      => "📁 打开";

    // ── Backups ────────────────────────────────────────────────────────
    public string BackupCreate       => "💾  创建备份";
    public string BackupRestore      => "↩ 恢复";
    public string BackupCount        => "个备份";

    // ── Info tab ───────────────────────────────────────────────────────
    public string InfoGame           => "游戏";
    public string InfoCategory       => "类别";
    public string InfoSteamId        => "Steam 应用 ID";
    public string InfoDefaultPort    => "默认端口";
    public string InfoRcon           => "RCON";
    public string InfoDescription    => "描述";

    // ── Add dialog ─────────────────────────────────────────────────────
    public string DialogTitle        => "新建游戏服务器";
    public string DialogGame         => "游戏";
    public string DialogName         => "服务器名称";
    public string DialogInstall      => "安装目录";
    public string DialogCancel       => "取消";
    public string DialogCreate       => "创建服务器";

    // ── Global settings page ───────────────────────────────────────────
    public string GlobalSettings     => "设置";
    public string DiscordSection     => "Discord 通知";
    public string DiscordEnable      => "启用 Discord 通知";
    public string DiscordWebhook     => "Webhook URL";
    public string DiscordTest        => "测试";
    public string DiscordSave        => "保存";
    public string GeneralSection     => "常规设置";
    public string DefaultInstallDir  => "默认安装目录";
    public string SteamCmdDir        => "SteamCMD 目录";
    public string AboutSection       => "关于";

    // ── Empty state ────────────────────────────────────────────────────
    public string EmptyTitle         => "在左侧选择服务器";
    public string EmptySubtitle      => "或添加一个新服务器";

    // ── Installing bar ─────────────────────────────────────────────────
    public string InstallingText     => "安装 / 更新中...";
    public string InstallDone        => "安装完成";

    // ── RCON messages ──────────────────────────────────────────────────
    public string RconConnectedMsg    => "已连接。";
    public string RconFailedMsg       => "连接失败。";
    public string RconDisconnectedMsg => "已断开。";

    // ── Backup / Restore messages ──────────────────────────────────────
    public string BackupCreating     => "正在创建备份...";
    public string BackupDone         => "已完成";
    public string RestoreStopFirst   => "恢复前请先停止服务器。";
    public string RestoreStarting    => "正在恢复...";
    public string RestoreDone        => "恢复完成。";

    // ── Port checker messages ──────────────────────────────────────────
    public string PortChecking       => "正在检查...";
    public string ExternalIp         => "外部 IP";

    public void Save(ConfigService config) { }
    public void Load(ConfigService config) { }
}
