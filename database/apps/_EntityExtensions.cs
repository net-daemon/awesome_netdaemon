using NetDaemon.Common;
using NetDaemon.Common.Fluent;

namespace Netdaemon.Generated.Extensions
{
    public static partial class EntityExtension
    {
        public static ScriptEntities ScriptEx(this NetDaemonApp app) => new ScriptEntities(app);
        public static MediaPlayerEntities MediaPlayerEx(this NetDaemonApp app) => new MediaPlayerEntities(app);
        public static SwitchEntities SwitchEx(this NetDaemonApp app) => new SwitchEntities(app);
        public static SceneEntities SceneEx(this NetDaemonApp app) => new SceneEntities(app);
        public static CameraEntities CameraEx(this NetDaemonApp app) => new CameraEntities(app);
        public static LightEntities LightEx(this NetDaemonApp app) => new LightEntities(app);
        public static AutomationEntities AutomationEx(this NetDaemonApp app) => new AutomationEntities(app);
    }

    public partial class ScriptEntities
    {
        private readonly NetDaemonApp _app;
        public ScriptEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity TvOffScene => _app.Entity("script.tv_off_scene");
        public IEntity MorningScene => _app.Entity("script.morning_scene");
        public IEntity EveningScene => _app.Entity("script.evening_scene");
        public IEntity Zigbee2mqttRename => _app.Entity("script.zigbee2mqtt_rename");
        public IEntity CleaningScene => _app.Entity("script.cleaning_scene");
        public IEntity FilmScene => _app.Entity("script.film_scene");
        public IEntity Setnightmode => _app.Entity("script.setnightmode");
        public IEntity TvScene => _app.Entity("script.tv_scene");
        public IEntity NightScene => _app.Entity("script.night_scene");
        public IEntity Zigbee2mqttRemove => _app.Entity("script.zigbee2mqtt_remove");
        public IEntity Notify => _app.Entity("script.notify");
        public IEntity NotifyGreet => _app.Entity("script.notify_greet");
        public IEntity DayScene => _app.Entity("script.day_scene");
        public IEntity ColorScene => _app.Entity("script.color_scene");
        public IEntity E1586350051032 => _app.Entity("script.1586350051032");
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonApp _app;
        public MediaPlayerEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IMediaPlayer Kok => _app.MediaPlayer("media_player.kok");
        public IMediaPlayer PlexPlexWebChromeLinux2 => _app.MediaPlayer("media_player.plex_plex_web_chrome_linux_2");
        public IMediaPlayer PlexChrome2 => _app.MediaPlayer("media_player.plex_chrome_2");
        public IMediaPlayer TvNere => _app.MediaPlayer("media_player.tv_nere");
        public IMediaPlayer PlexPlexCastChromecast => _app.MediaPlayer("media_player.plex_plex_cast_chromecast");
        public IMediaPlayer ShieldTv => _app.MediaPlayer("media_player.shield_tv");
        public IMediaPlayer Vardagsrum => _app.MediaPlayer("media_player.vardagsrum");
        public IMediaPlayer Sovrum => _app.MediaPlayer("media_player.sovrum");
        public IMediaPlayer PlexChrome3 => _app.MediaPlayer("media_player.plex_chrome_3");
        public IMediaPlayer TvRummetGh => _app.MediaPlayer("media_player.tv_rummet_gh");
        public IMediaPlayer PlexChrome => _app.MediaPlayer("media_player.plex_chrome");
        public IMediaPlayer Huset => _app.MediaPlayer("media_player.huset");
        public IMediaPlayer PlexChromecast => _app.MediaPlayer("media_player.plex_chromecast");
        public IMediaPlayer MelkersTv => _app.MediaPlayer("media_player.melkers_tv");
        public IMediaPlayer Gym => _app.MediaPlayer("media_player.gym");
        public IMediaPlayer TvUppe => _app.MediaPlayer("media_player.tv_uppe");
        public IMediaPlayer PlexPlexWebChrome => _app.MediaPlayer("media_player.plex_plex_web_chrome");
        public IMediaPlayer Nestaudio0573 => _app.MediaPlayer("media_player.nestaudio0573");
        public IMediaPlayer PlexPlexForAndroidTvShieldAndroidTv => _app.MediaPlayer("media_player.plex_plex_for_android_tv_shield_android_tv");
        public IMediaPlayer Shield => _app.MediaPlayer("media_player.shield");
        public IMediaPlayer PlexPlexWebChromeLinux => _app.MediaPlayer("media_player.plex_plex_web_chrome_linux");
        public IMediaPlayer PlexTomasIpad => _app.MediaPlayer("media_player.plex_tomas_ipad");
        public IMediaPlayer SallysHogtalare => _app.MediaPlayer("media_player.sallys_hogtalare");
        public IMediaPlayer TvGym => _app.MediaPlayer("media_player.tv_gym");
        public IMediaPlayer MelkersRum => _app.MediaPlayer("media_player.melkers_rum");
        public IMediaPlayer PlexKodiAddOnLibreelec => _app.MediaPlayer("media_player.plex_kodi_add_on_libreelec");
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonApp _app;
        public SwitchEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity Ac51bc0cfe8 => _app.Entity("switch.ac_51bc0cfe_8");
        public IEntity MelkersRumFonster => _app.Entity("switch.melkers_rum_fonster");
        public IEntity Ac44bc0cfe1 => _app.Entity("switch.ac_44bc0cfe_1");
        public IEntity NetdaemonWebhook => _app.Entity("switch.netdaemon_webhook");
        public IEntity NetdaemonHacsNotifyOnUpdate => _app.Entity("switch.netdaemon_hacs_notify_on_update");
        public IEntity Ac29bc0cfe6 => _app.Entity("switch.ac_29bc0cfe_6");
        public IEntity Ac34bc0cfe6 => _app.Entity("switch.ac_34bc0cfe_6");
        public IEntity NetdaemonRoomSpecific => _app.Entity("switch.netdaemon_room_specific");
        public IEntity Ac294734616 => _app.Entity("switch.ac_2947346_16");
        public IEntity ShellyRelay => _app.Entity("switch.shelly_relay");
        public IEntity Switch8MelkersTv => _app.Entity("switch.switch8_melkers_tv");
        public IEntity NetdaemonDebugApp => _app.Entity("switch.netdaemon_debug_app");
        public IEntity Ac51bc0cfe4 => _app.Entity("switch.ac_51bc0cfe_4");
        public IEntity Ac18ce36211 => _app.Entity("switch.ac_18ce362_11");
        public IEntity NetdaemonFrys => _app.Entity("switch.netdaemon_frys");
        public IEntity Tv => _app.Entity("switch.tv");
        public IEntity Zigbee2mqttMainJoin => _app.Entity("switch.zigbee2mqtt_main_join");
        public IEntity JulbelysningKokV => _app.Entity("switch.julbelysning_kok_v");
        public IEntity JulbelysningVardagsrumH => _app.Entity("switch.julbelysning_vardagsrum_h");
        public IEntity Ac81bc0cfe1 => _app.Entity("switch.ac_81bc0cfe_1");
        public IEntity Ac55bc0cfe7 => _app.Entity("switch.ac_55bc0cfe_7");
        public IEntity Film => _app.Entity("switch.film");
        public IEntity Ac36bc0cfe8 => _app.Entity("switch.ac_36bc0cfe_8");
        public IEntity JulbelysningTomasRum => _app.Entity("switch.julbelysning_tomas_rum");
        public IEntity Ac93bc0cfe2 => _app.Entity("switch.ac_93bc0cfe_2");
        public IEntity Ac67bc0cfe4 => _app.Entity("switch.ac_67bc0cfe_4");
        public IEntity NetdaemonMotorvarmare => _app.Entity("switch.netdaemon_motorvarmare");
        public IEntity ComputerTomas => _app.Entity("switch.computer_tomas");
        public IEntity Kodi => _app.Entity("switch.kodi");
        public IEntity NetdaemonHouseStateManager => _app.Entity("switch.netdaemon_house_state_manager");
        public IEntity JulbelysningVardagsrumV => _app.Entity("switch.julbelysning_vardagsrum_v");
        public IEntity Ac294734614 => _app.Entity("switch.ac_2947346_14");
        public IEntity Ac18ce36212 => _app.Entity("switch.ac_18ce362_12");
        public IEntity Ac52bc0cfe1 => _app.Entity("switch.ac_52bc0cfe_1");
        public IEntity MotorvarmareHoger => _app.Entity("switch.motorvarmare_hoger");
        public IEntity Ac294734615 => _app.Entity("switch.ac_2947346_15");
        public IEntity SallysRumFonster => _app.Entity("switch.sallys_rum_fonster");
        public IEntity JulbelysningKokH => _app.Entity("switch.julbelysning_kok_h");
        public IEntity Sonoff1Relay => _app.Entity("switch.sonoff1_relay");
        public IEntity ADiod => _app.Entity("switch.a_diod");
        public IEntity NetdaemonPersistantApp => _app.Entity("switch.netdaemon_persistant_app");
        public IEntity TvrumVagg => _app.Entity("switch.tvrum_vagg");
        public IEntity NetdaemonCalendarTrash => _app.Entity("switch.netdaemon_calendar_trash");
        public IEntity NetdaemonMagicCube => _app.Entity("switch.netdaemon_magic_cube");
        public IEntity NetdaemonHelloWorldApp => _app.Entity("switch.netdaemon_hello_world_app");
        public IEntity Ac50bc0cfe8 => _app.Entity("switch.ac_50bc0cfe_8");
        public IEntity NetdaemonWelcomeHome => _app.Entity("switch.netdaemon_welcome_home");
        public IEntity Ac2bc0cfe1 => _app.Entity("switch.ac_2bc0cfe_1");
        public IEntity JulbelysningTvrummet => _app.Entity("switch.julbelysning_tvrummet");
        public IEntity NetdaemonTv => _app.Entity("switch.netdaemon_tv");
        public IEntity NetdaemonLightManager => _app.Entity("switch.netdaemon_light_manager");
        public IEntity Ac39bc0cfe7 => _app.Entity("switch.ac_39bc0cfe_7");
        public IEntity Ac15bc0cfe1 => _app.Entity("switch.ac_15bc0cfe_1");
        public IEntity NetdaemonMotion => _app.Entity("switch.netdaemon_motion");
    }

    public partial class SceneEntities
    {
        private readonly NetDaemonApp _app;
        public SceneEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity Kvall => _app.Entity("scene.kvall");
        public IEntity Morgon => _app.Entity("scene.morgon");
        public IEntity Natt => _app.Entity("scene.natt");
        public IEntity Stadning => _app.Entity("scene.stadning");
        public IEntity Dag => _app.Entity("scene.dag");
    }

    public partial class CameraEntities
    {
        private readonly NetDaemonApp _app;
        public CameraEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public ICamera FramsidanProfile000Mainstream => _app.Camera("camera.framsidan_profile000_mainstream");
        public ICamera MyCamera => _app.Camera("camera.my_camera");
        public ICamera FramsidanProfile000Mainstream2 => _app.Camera("camera.framsidan_profile000_mainstream_2");
        public ICamera KameraStream => _app.Camera("camera.kamera_stream");
        public ICamera Cam1 => _app.Camera("camera.cam1");
        public ICamera Kamera3 => _app.Camera("camera.kamera_3");
    }

    public partial class LightEntities
    {
        private readonly NetDaemonApp _app;
        public LightEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity Tvrummet => _app.Entity("light.tvrummet");
        public IEntity HallDorr => _app.Entity("light.hall_dorr");
        public IEntity MelkersRumFonster => _app.Entity("light.melkers_rum_fonster");
        public IEntity KokFonster => _app.Entity("light.kok_fonster");
        public IEntity TvrumFonsterHoger => _app.Entity("light.tvrum_fonster_hoger");
        public IEntity GymLed => _app.Entity("light.gym_led");
        public IEntity JulbelysningTomasRum => _app.Entity("light.julbelysning_tomas_rum");
        public IEntity TvrumFonsterVanster => _app.Entity("light.tvrum_fonster_vanster");
        public IEntity TomasRumFonster => _app.Entity("light.tomas_rum_fonster");
        public IEntity Kok => _app.Entity("light.kok");
        public IEntity KokLillaFonster => _app.Entity("light.kok_lilla_fonster");
        public IEntity JulbelysningKokV => _app.Entity("light.julbelysning_kok_v");
        public IEntity JulbelysningKokH => _app.Entity("light.julbelysning_kok_h");
        public IEntity HallByra => _app.Entity("light.hall_byra");
        public IEntity SallysRum => _app.Entity("light.sallys_rum");
        public IEntity FarstukvistLed => _app.Entity("light.farstukvist_led");
        public IEntity TvrumVagg => _app.Entity("light.tvrum_vagg");
        public IEntity SovrumByra => _app.Entity("light.sovrum_byra");
        public IEntity JulbelysningVardagsrumH => _app.Entity("light.julbelysning_vardagsrum_h");
        public IEntity Sovrum => _app.Entity("light.sovrum");
        public IEntity Farstukvisten => _app.Entity("light.farstukvisten");
        public IEntity TvrumBakgrundTv => _app.Entity("light.tvrum_bakgrund_tv");
        public IEntity Vardagsrum => _app.Entity("light.vardagsrum");
        public IEntity VardagsrumFonsterHoger => _app.Entity("light.vardagsrum_fonster_hoger");
        public IEntity SallysRumFonster => _app.Entity("light.sallys_rum_fonster");
        public IEntity MelkersRum => _app.Entity("light.melkers_rum");
        public IEntity TomasRum => _app.Entity("light.tomas_rum");
        public IEntity VardagsrumFonsterVanster => _app.Entity("light.vardagsrum_fonster_vanster");
        public IEntity JulbelysningTvrummet => _app.Entity("light.julbelysning_tvrummet");
        public IEntity VardagsrumFonsterMitten => _app.Entity("light.vardagsrum_fonster_mitten");
        public IEntity Ambient => _app.Entity("light.ambient");
        public IEntity SovrumFonster => _app.Entity("light.sovrum_fonster");
        public IEntity JulbelysningSovrum => _app.Entity("light.julbelysning_sovrum");
        public IEntity JulbelysningVardagsrumV => _app.Entity("light.julbelysning_vardagsrum_v");
    }

    public partial class AutomationEntities
    {
        private readonly NetDaemonApp _app;
        public AutomationEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity Automation3 => _app.Entity("automation.automation_3");
        public IEntity SetThemeAtStartup => _app.Entity("automation.set_theme_at_startup");
        public IEntity ZigbeeJoinDisabled => _app.Entity("automation.zigbee_join_disabled");
        public IEntity ZigbeeJoinEnabled => _app.Entity("automation.zigbee_join_enabled");
        public IEntity Zigbee2mqttLogLevel => _app.Entity("automation.zigbee2mqtt_log_level");
    }
}