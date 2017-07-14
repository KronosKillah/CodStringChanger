/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                                                     //        
//      Hi, I see that you got into my source...                                                                                       //
//      First, fuck off you leacher shit. Second, Dont take my damn offsets.                                                           //
//      I made this tool on trust that there are some decent people in the left in the modding community.                              //
//      Third, These offsets I found myself, way before they were released on NGU or any of those sites lol.                           //
//      But i realize that you obviously went to the effort of downloading JetBrains DotPeek for the purpose of stealing my dank hax,  //
//      So i ask you that you please give me some credit in the Leech tools you are going to add my blood, sweat and tears into.       //
//      I spent countless hours on this tool.                                                                                          //
//      But hey if you are reading this then at least you downloaded and used my tool so i thank you for that.                         //
//      Fuck you and have a nice day<3                                                                                                 // 
//                                  _   __                                    __ _____                                                 // 
//                                  | | / /                                   / /|____ |                                               //         
//                                  | |/ /  _ __   ___   _ __    ___   ___   / /     / /                                               // 
//                                  |    \ | '__| / _ \ | '_ \  / _ \ / __| < <      \ \                                               // 
//                                  | |\  \| |   | (_) || | | || (_) |\__ \  \ \ .___/ /                                               // 
//                                  \_| \_/|_|    \___/ |_| |_| \___/ |___/   \_\\____/                                                // 
//                                                                                                                                     //
//                                                                                                                                     //     
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//BO2 Free Memory 0x51000000

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using PS3Lib;
using System.Threading;


namespace StringChangerV4Fuckit
{
    public partial class Form1 : Form
    {
        public static string CurrentGame = " No current game";
        private Thread TargetInfo;
        private bool threadIsRunning = false;
        private bool isConnected = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("This Tool was created by Kronos\r\nThis tool was not leeched at all and as far as i know most of these offsets havent been released\r\nThanks for using my tool :)");
            //PS3.ConnectTarget(0);
            //PS3.AttachProcess();
            TargetInfo = new Thread(new ThreadStart(InfoWorker));
            tabControl2.Enabled = true;
            if (!File.Exists(@"Data/Bo2ToolSettings.json"))
                File.Create(@"Data/Bo2ToolSettings.json");

        }
        public void NEWS()
        {
            WebClient client = new WebClient();
            {
                string news = client.DownloadString("http://pastebin.com/raw/VmTCb7Gz");
                string changelog = client.DownloadString("http://pastebin.com/raw/gV1WngJF");
                NewsBox.Text = news.ToString();
                ChangeLogBox.Text = changelog.ToString();


            }
        }

        #region JSON File Saving
        /// <summary>
        /// Save File to JSON.
        /// </summary>
        
        public class Setting
        {
            public string name { get; set; }
            public string value { get; set; }
            public Setting(string Name, string Value)
            {
                name = Name;
                value = Value;
            }
        }
        public List<Setting> settingsList = new List<Setting>();
        public void Bo2SaveSettingsTool(string input, string textboxname)
        {
            Setting Bo2Setting = new Setting(input, textboxname);
            string output = JsonConvert.SerializeObject(Bo2Setting);
            using (StreamWriter sw = new StreamWriter("Data/BO2ToolSettings.json", true)) { sw.WriteLine(output); }
        }
        public void MW3SaveSettingsTool(string input, string textboxname)
        {
            Setting MW3Setting = new Setting(input, textboxname);
            string output = JsonConvert.SerializeObject(MW3Setting);
            using (StreamWriter sw = new StreamWriter("Data/MW3ToolSettings.json", true)) { sw.WriteLine(output); }
        }
        public void MW3LoadSettingsTool()
        {
            string settings_filepath = "Data/MW3ToolSettings.json";
            if (File.Exists(settings_filepath))
            {
                string[] Settings_MW3_content = File.ReadAllLines(settings_filepath);
                foreach (string line in Settings_MW3_content)
                {

                    Setting setting = JsonConvert.DeserializeObject<Setting>(line);
                    settingsList.Add(setting);
                    if(setting.name == "MW3PlayOnlineDescBox"){ MW3PlayOnlineDescBox.Text = setting.value; }
                    if (setting.name == "MW3PlayOnlineBox") { MW3PlayOnlineBox.Text = setting.value; }
                    if (setting.name == "MW3MultiplayerBox") { MW3MultiplayerBox.Text = setting.value; }
                    if (setting.name == "MW3MainMenuDescBox") { MW3MainMenuDescBox.Text = setting.value; }
                    if (setting.name == "MW3MainMenuBox") { MW3MainMenuBox.Text = setting.value; }
                    if (setting.name == "MW3OptionsDescBox") { MW3OptionsDescBox.Text = setting.value; }
                    if (setting.name == "MW3OptionsBox") { MW3OptionsBox.Text = setting.value; }
                    if (setting.name == "MW3StoreDescBox") { MW3StoreDescBox.Text = setting.value; }
                    if (setting.name == "MW3StoreBox") { MW3StoreBox.Text = setting.value; }
                    if (setting.name == "MW3VaultDescBox") { MW3VaultDescBox.Text = setting.value; }
                    if (setting.name == "MW3VaultBox") { MW3VaultBox.Text = setting.value; }
                    if (setting.name == "MW3EliteDescBox") { MW3EliteDescBox.Text = setting.value; }
                    if (setting.name == "MW3EliteBox") { MW3EliteBox.Text = setting.value; }
                    if (setting.name == "MW3LanPlayDescBox") { MW3LanPlayDescBox.Text = setting.value; }
                    if (setting.name == "MW3LanPlayBox") { MW3LanPlayBox.Text = setting.value; }
                    if (setting.name == "MW3SplitScreenBox") { MW3SplitScreenBox.Text = setting.value; }
                    if (setting.name == "MW3SplitScreenDescBox") { MW3SplitScreenDescBox.Text = setting.value; }
                    if (setting.name == "MW3AddControllerSplitScreenBox") { MW3AddControllerSplitScreenBox.Text = setting.value; }
                    if (setting.name == "MW3BarracksDescBox") { MW3BarracksDescBox.Text = setting.value; }
                    if (setting.name == "MW3BarracksBox") { MW3BarracksBox.Text = setting.value; }
                    if (setting.name == "MW3CallsignDescBox") { MW3CallsignDescBox.Text = setting.value; }
                    if (setting.name == "MW3CallsignBox") { MW3CallsignBox.Text = setting.value; }
                    if (setting.name == "MW3CreateAClassDescBox") { MW3CreateAClassDescBox.Text = setting.value; }
                    if (setting.name == "MW3CreateAClassBox") { MW3CreateAClassBox.Text = setting.value; }
                    if (setting.name == "MW3PrivateMatchDescBox") { MW3PrivateMatchDescBox.Text = setting.value; }
                    if (setting.name == "MW3PrivateMatchBox") { MW3PrivateMatchBox.Text = setting.value; }
                    if (setting.name == "MW3FindGameDescBox") { MW3FindGameDescBox.Text = setting.value; }
                    if (setting.name == "MW3FindGameBox") { MW3FindGameBox.Text = setting.value; }
                    if (setting.name == "MW3ASSAULTRIFLESBox") { MW3ASSAULTRIFLESBox.Text = setting.value; }
                    if (setting.name == "MW3FADBox") { MW3FADBox.Text = setting.value; }
                    if (setting.name == "MW3AK47Box") { MW3AK47Box.Text = setting.value; }
                    if (setting.name == "MW3MK14Box") { MW3MK14Box.Text = setting.value; }
                    if (setting.name == "MW3ACRBox") { MW3ACRBox.Text = setting.value; }
                    if (setting.name == "MW3G36CBox") { MW3G36CBox.Text = setting.value; }
                    if (setting.name == "MW3TYPE95Box") { MW3TYPE95Box.Text = setting.value; }
                    if (setting.name == "MW3CM901Box") { MW3CM901Box.Text = setting.value; }
                    if (setting.name == "MW3SCARLBox") { MW3SCARLBox.Text = setting.value; }
                    if (setting.name == "MW3M16A4Box") { MW3M16A4Box.Text = setting.value; }
                    if (setting.name == "MW3M4A1Box") { MW3M4A1Box.Text = setting.value; }
                    if (setting.name == "MW3ShotGunsBox") { MW3ShotGunsBox.Text = setting.value; }
                    if (setting.name == "MW3MODEL1887Box") { MW3MODEL1887Box.Text = setting.value; }
                    if (setting.name == "MW3STRIKERBox") { MW3STRIKERBox.Text = setting.value; }
                    if (setting.name == "MW3AA12Box") { MW3AA12Box.Text = setting.value; }
                    if (setting.name == "MW3SPAS12Box") { MW3SPAS12Box.Text = setting.value; }
                    if (setting.name == "MW3KSG12Box") { MW3KSG12Box.Text = setting.value; }
                    if (setting.name == "MW3USAS12Box") { MW3USAS12Box.Text = setting.value; }
                    if (setting.name == "MW3LMGsStringBox") { MW3LMGsStringBox.Text = setting.value; }
                    if (setting.name == "MW3M60E4Box") { MW3M60E4Box.Text = setting.value; }
                    if (setting.name == "MW3MK46Box") { MW3MK46Box.Text = setting.value; }
                    if (setting.name == "MW3PKPPECHENEGBox") { MW3PKPPECHENEGBox.Text = setting.value; }
                    if (setting.name == "MW3MG36Box") { MW3MG36Box.Text = setting.value; }
                    if (setting.name == "MW3L86LSWBox") { MW3L86LSWBox.Text = setting.value; }
                    if (setting.name == "MW3SniperRilesBox") { MW3SniperRilesBox.Text = setting.value; }
                    if (setting.name == "MW3MSRBox") { MW3MSRBox.Text = setting.value; }
                    if (setting.name == "MW3RsassBox") { MW3RsassBox.Text = setting.value; }
                    if (setting.name == "MW3AS50Box") { MW3AS50Box.Text = setting.value; }
                    if (setting.name == "MW3DragunovBox") { MW3DragunovBox.Text = setting.value; }
                    if (setting.name == "MW3L118ABox") { MW3L118ABox.Text = setting.value; }
                    if (setting.name == "MW3Barret50callBox") { MW3Barret50callBox.Text = setting.value; }
                    if (setting.name == "MW3RiotShieldBox") { MW3RiotShieldBox.Text = setting.value; }
                    if (setting.name == "MW3SMGsStringBox") { MW3SMGsStringBox.Text = setting.value; }
                    if (setting.name == "MW3MP7Box") { MW3MP7Box.Text = setting.value; }
                    if (setting.name == "MW3PM9Box") { MW3PM9Box.Text = setting.value; }
                    if (setting.name == "MW3P90Box") { MW3P90Box.Text = setting.value; }
                    if (setting.name == "MW3PP90M1Box") { MW3PP90M1Box.Text = setting.value; }
                    if (setting.name == "MW3UMP45Box") { MW3UMP45Box.Text = setting.value; }
                    if (setting.name == "MW3MP5Box") { MW3MP5Box.Text = setting.value; }
                    if (setting.name == "MW3MachinePistolsBox") { MW3MachinePistolsBox.Text = setting.value; }
                    if (setting.name == "MW3G18Box") { MW3G18Box.Text = setting.value; }
                    if (setting.name == "MW3SkorpionBox") { MW3SkorpionBox.Text = setting.value; }
                    if (setting.name == "MW3MP9Box") { MW3MP9Box.Text = setting.value; }
                    if (setting.name == "MW3FMG9Box") { MW3FMG9Box.Text = setting.value; }
                    if (setting.name == "MW3DesertEagleBox") { MW3DesertEagleBox.Text = setting.value; }
                    if (setting.name == "MW3HandGunsBox") { MW3HandGunsBox.Text = setting.value; }
                    if (setting.name == "MW3FiveSevenBox") { MW3FiveSevenBox.Text = setting.value; }
                    if (setting.name == "MW344MagnumBox") { MW344MagnumBox.Text = setting.value; }
                    if (setting.name == "MW3MP412Box") { MW3MP412Box.Text = setting.value; }
                    if (setting.name == "MW3P99Box") { MW3P99Box.Text = setting.value; }
                    if (setting.name == "MW3USP45Box") { MW3USP45Box.Text = setting.value; }
                    if (setting.name == "MW3LaunchersBox") { MW3LaunchersBox.Text = setting.value; }
                    if (setting.name == "MW3RPG7Box") { MW3RPG7Box.Text = setting.value; }
                    if (setting.name == "MW3M320GLMBox") { MW3M320GLMBox.Text = setting.value; }
                    if (setting.name == "MW3XM25Box") { MW3XM25Box.Text = setting.value; }
                    if (setting.name == "MW3StingerBox") { MW3StingerBox.Text = setting.value; }
                    if (setting.name == "MW3JavelinBox") { MW3JavelinBox.Text = setting.value; }
                    if (setting.name == "MW3SMAWBox") { MW3SMAWBox.Text = setting.value; }

                }
            }
            else MessageBox.Show(settings_filepath + " is missing! :(");

        }
        public void Bo2LoadSettingsTool()
        {


            string settings_filepath = "Data/BO2ToolSettings.json";
            if (File.Exists(settings_filepath))
            {
                string[] Settings_BO2_content = File.ReadAllLines(settings_filepath);
                foreach (string line in Settings_BO2_content)
                {

                    Setting setting = JsonConvert.DeserializeObject<Setting>(line);
                    settingsList.Add(setting);
                    if (setting.name == "pubmatchBox") { pubmatchBox.Text = setting.value; }
                    if (setting.name == "multiplayerBox") { multiplayerBox.Text = setting.value; }
                    if (setting.name == "pubmatchDescBox") { pubmatchDescBox.Text = setting.value; }
                    if (setting.name == "storeDescBox") { storeDescBox.Text = setting.value; }
                    if (setting.name == "storeBox") { storeBox.Text = setting.value; }
                    if (setting.name == "optionsDescBox") { optionsDescBox.Text = setting.value; }
                    if (setting.name == "optionsBox") { optionsBox.Text = setting.value; }
                    if (setting.name == "barracksDescBox") { barracksDescBox.Text = setting.value; }
                    if (setting.name == "barracksBox") { barracksBox.Text = setting.value; }
                    if (setting.name == "codtvDescBox") { codtvDescBox.Text = setting.value; }
                    if (setting.name == "codtvBox") { codtvBox.Text = setting.value; }
                    if (setting.name == "theaterDescBox") { theaterDescBox.Text = setting.value; }
                    if (setting.name == "theaterBox") { theaterBox.Text = setting.value; }
                    if (setting.name == "customGameDescBox") { customGameDescBox.Text = setting.value; }
                    if (setting.name == "customGameBox") { customGameBox.Text = setting.value; }
                    if (setting.name == "leagueDescBox") { leagueDescBox.Text = setting.value; }
                    if (setting.name == "leaguePlayBox") { leaguePlayBox.Text = setting.value; }
                    if (setting.name == "localBox") { localBox.Text = setting.value; }
                    if (setting.name == "lanPartyBox") { lanPartyBox.Text = setting.value; }
                    if (setting.name == "playOnlineBox") { playOnlineBox.Text = setting.value; }
                    if (setting.name == "playersOnlineBox") { playersOnlineBox.Text = setting.value; }
                    if (setting.name == "addSplitscreenControllerBox") { addSplitscreenControllerBox.Text = setting.value; }
                    if (setting.name == "backButtonBox") { backButtonBox.Text = setting.value; }
                    if (setting.name == "friendsPlayingBox") { friendsPlayingBox.Text = setting.value; }
                    if (setting.name == "scorestreaksDescBox") { scorestreaksDescBox.Text = setting.value; }
                    if (setting.name == "scorestreaksBox") { scorestreaksBox.Text = setting.value; }
                    if (setting.name == "createclassDescBox") { createclassDescBox.Text = setting.value; }
                    if (setting.name == "createaclassBox") { createaclassBox.Text = setting.value; }
                    if (setting.name == "findmatchDescBox") { findmatchDescBox.Text = setting.value; }
                    if (setting.name == "findMatchBox") { findMatchBox.Text = setting.value; }
                    if (setting.name == "livestreamDescBox") { livestreamDescBox.Text = setting.value; }
                    if (setting.name == "livestreamBox") { livestreamBox.Text = setting.value; }
                    if (setting.name == "deadScilenceDescBox") { deadScilenceDescBox.Text = setting.value; }
                    if (setting.name == "deadscilenceBox") { deadscilenceBox.Text = setting.value; }
                    if (setting.name == "tacMaskDescBox") { tacMaskDescBox.Text = setting.value; }
                    if (setting.name == "tacMaskBox") { tacMaskBox.Text = setting.value; }
                    if (setting.name == "engineerDescBox") { engineerDescBox.Text = setting.value; }
                    if (setting.name == "engineerBox") { engineerBox.Text = setting.value; }
                    if (setting.name == "exCondDesBox") { exCondDesBox.Text = setting.value; }
                    if (setting.name == "exCondBox") { exCondBox.Text = setting.value; }
                    if (setting.name == "dexterityDescBox") { dexterityDescBox.Text = setting.value; }
                    if (setting.name == "dexterityBox") { dexterityBox.Text = setting.value; }
                    if (setting.name == "scavengerDescBox") { scavengerDescBox.Text = setting.value; }
                    if (setting.name == "scavengerBox") { scavengerBox.Text = setting.value; }
                    if (setting.name == "hardwiredDescBox") { hardwiredDescBox.Text = setting.value; }
                    if (setting.name == "hardwiredBox") { hardwiredBox.Text = setting.value; }
                    if (setting.name == "fasthandsDescBox") { fasthandsDescBox.Text = setting.value; }
                    if (setting.name == "fasthandsBox") { fasthandsBox.Text = setting.value; }
                    if (setting.name == "coldbloodedDescBox") { coldbloodedDescBox.Text = setting.value; }
                    if (setting.name == "coldbloodBox") { coldbloodBox.Text = setting.value; }
                    if (setting.name == "toughnessDescBox") { toughnessDescBox.Text = setting.value; }
                    if (setting.name == "toughnessBox") { toughnessBox.Text = setting.value; }
                    if (setting.name == "ghostDescBox") { ghostDescBox.Text = setting.value; }
                    if (setting.name == "ghostBox") { ghostBox.Text = setting.value; }
                    if (setting.name == "flakjacketDescBox") { flakjacketDescBox.Text = setting.value; }
                    if (setting.name == "flakjacketBox") { flakjacketBox.Text = setting.value; }
                    if (setting.name == "blindeyeDescBox") { blindeyeDescBox.Text = setting.value; }
                    if (setting.name == "blindeyeBox") { blindeyeBox.Text = setting.value; }
                    if (setting.name == "hardlineDescBox") { hardlineDescBox.Text = setting.value; }
                    if (setting.name == "hardlineBox") { hardlineBox.Text = setting.value; }
                    if (setting.name == "lightweightDescBox") { lightweightDescBox.Text = setting.value; }
                    if (setting.name == "lightweightBox") { lightweightBox.Text = setting.value; }
                    if (setting.name == "awarenessDescBox") { awarenessDescBox.Text = setting.value; }
                    if (setting.name == "awarenessBox") { awarenessBox.Text = setting.value; }
                    if (setting.name == "c4DescBox") { c4DescBox.Text = setting.value; }
                    //if (setting.name == "c4box") { c4box.Text = setting.value; }
                    if (setting.name == "bouncingbettyDescBox") { bouncingbettyDescBox.Text = setting.value; }
                    if (setting.name == "bouncingbettyBox") { bouncingbettyBox.Text = setting.value; }
                    if (setting.name == "combataxeDescBox") { combataxeDescBox.Text = setting.value; }
                    if (setting.name == "combataxeBox") { combataxeBox.Text = setting.value; }
                    if (setting.name == "semtexDescBox") { semtexDescBox.Text = setting.value; }
                    if (setting.name == "semtexBox") { semtexBox.Text = setting.value; }
                    //if (setting.name == "claymoreDescbox") { claymoreDescbox.Text = setting.value; }
                    if (setting.name == "grenadeDescBox") { grenadeDescBox.Text = setting.value; }
                    if (setting.name == "claymoreBox") { claymoreBox.Text = setting.value; }
                    if (setting.name == "grenadeBox") { grenadeBox.Text = setting.value; }
                    if (setting.name == "tacinsertDescBox") { tacinsertDescBox.Text = setting.value; }
                    if (setting.name == "tacinsertBox") { tacinsertBox.Text = setting.value; }
                    if (setting.name == "trophysystemDescBox") { trophysystemDescBox.Text = setting.value; }
                    if (setting.name == "trophysystemBox") { trophysystemBox.Text = setting.value; }
                    if (setting.name == "flashbagDescBox") { flashbagDescBox.Text = setting.value; }
                    if (setting.name == "flashbangBox") { flashbangBox.Text = setting.value; }
                    if (setting.name == "blackhatDescBox") { blackhatDescBox.Text = setting.value; }
                    if (setting.name == "blackhatBox") { blackhatBox.Text = setting.value; }
                    if (setting.name == "shockchargeDescBox") { shockchargeDescBox.Text = setting.value; }
                    if (setting.name == "shockchargeBox") { shockchargeBox.Text = setting.value; }
                    if (setting.name == "empgrenadeDescBox") { empgrenadeDescBox.Text = setting.value; }
                    if (setting.name == "empgrenadeBox") { empgrenadeBox.Text = setting.value; }
                    if (setting.name == "sensorgrenadeDescBox") { sensorgrenadeDescBox.Text = setting.value; }
                    if (setting.name == "sensorgrenadeBox") { sensorgrenadeBox.Text = setting.value; }
                    if (setting.name == "stungrenadeDescBox") { stungrenadeDescBox.Text = setting.value; }
                    if (setting.name == "stungrenadeBox") { stungrenadeBox.Text = setting.value; }
                    if (setting.name == "concussionDescBox") { concussionDescBox.Text = setting.value; }
                    if (setting.name == "concussionBox") { concussionBox.Text = setting.value; }
                    if (setting.name == "assaultriflesBox") { assaultriflesBox.Text = setting.value; }
                    if (setting.name == "an94DescBox") { an94DescBox.Text = setting.value; }
                    if (setting.name == "an94Box") { an94Box.Text = setting.value; }
                    if (setting.name == "m8a1DescBox") { m8a1DescBox.Text = setting.value; }
                    if (setting.name == "m8a1Box") { m8a1Box.Text = setting.value; }
                    if (setting.name == "smrDescBox") { smrDescBox.Text = setting.value; }
                    if (setting.name == "smrBox") { smrBox.Text = setting.value; }
                    if (setting.name == "scarDescBox") { scarDescBox.Text = setting.value; }
                    if (setting.name == "scarhBox") { scarhBox.Text = setting.value; }
                    if (setting.name == "m27DescBox") { m27DescBox.Text = setting.value; }
                    if (setting.name == "m27Box") { m27Box.Text = setting.value; }
                    if (setting.name == "faloswDescBox") { faloswDescBox.Text = setting.value; }
                    if (setting.name == "faloswBox") { faloswBox.Text = setting.value; }
                    if (setting.name == "swat556DescBox") { swat556DescBox.Text = setting.value; }
                    if (setting.name == "swat556Box") { swat556Box.Text = setting.value; }
                    if (setting.name == "type25DescBox") { type25DescBox.Text = setting.value; }
                    if (setting.name == "type25Box") { type25Box.Text = setting.value; }
                    if (setting.name == "mtarDescBox") { mtarDescBox.Text = setting.value; }
                    if (setting.name == "mtarBox") { mtarBox.Text = setting.value; }
                    if (setting.name == "m1216DescBox") { m1216DescBox.Text = setting.value; }
                    if (setting.name == "m1216Box") { m1216Box.Text = setting.value; }
                    if (setting.name == "ksgDescBox") { ksgDescBox.Text = setting.value; }
                    if (setting.name == "ksgBox") { ksgBox.Text = setting.value; }
                    if (setting.name == "s12DescBox") { s12DescBox.Text = setting.value; }
                    if (setting.name == "s12Box") { s12Box.Text = setting.value; }
                    if (setting.name == "r870mcsDescBox") { r870mcsDescBox.Text = setting.value; }
                    if (setting.name == "r870mcsBox") { r870mcsBox.Text = setting.value; }
                    if (setting.name == "HAMRDescBox") { HAMRDescBox.Text = setting.value; }
                    if (setting.name == "HAMRBox") { HAMRBox.Text = setting.value; }
                    if (setting.name == "LSATDescBox") { LSATDescBox.Text = setting.value; }
                    if (setting.name == "LSATBox") { LSATBox.Text = setting.value; }
                    if (setting.name == "QBBLSWDescBox") { QBBLSWDescBox.Text = setting.value; }
                    if (setting.name == "QBBLSWBox") { QBBLSWBox.Text = setting.value; }
                    if (setting.name == "MK48DescBox") { MK48DescBox.Text = setting.value; }
                    if (setting.name == "MK48Box") { MK48Box.Text = setting.value; }
                    if (setting.name == "XPR50DescBox") { XPR50DescBox.Text = setting.value; }
                    if (setting.name == "XPR50Box") { XPR50Box.Text = setting.value; }
                    if (setting.name == "BallistaDescBox") { BallistaDescBox.Text = setting.value; }
                    if (setting.name == "BallistaBox") { BallistaBox.Text = setting.value; }
                    if (setting.name == "DSR50DescBox") { DSR50DescBox.Text = setting.value; }
                    if (setting.name == "DSR50Box") { DSR50Box.Text = setting.value; }
                    if (setting.name == "SVUASDescBox") { SVUASDescBox.Text = setting.value; }
                    if (setting.name == "SVUASBox") { SVUASBox.Text = setting.value; }
                    if (setting.name == "assaultshieldDescBox") { assaultshieldDescBox.Text = setting.value; }
                    if (setting.name == "assaultshieldBox") { assaultshieldBox.Text = setting.value; }
                    if (setting.name == "partygamesBox") { partygamesBox.Text = setting.value; }
                    if (setting.name == "combattrainingBox") { combattrainingBox.Text = setting.value; }
                    if (setting.name == "hardcoreBox") { hardcoreBox.Text = setting.value; }
                    if (setting.name == "coreBox") { coreBox.Text = setting.value; }
                    if (setting.name == "playlistsBox") { playlistsBox.Text = setting.value; }


                }
            }
            else MessageBox.Show(settings_filepath + " is missing! :(");
        }
        public void SaveBo2Settings()
        {
            Bo2SaveSettingsTool("pubmatchBox", pubmatchBox.Text);
            Bo2SaveSettingsTool("multiplayerBox", multiplayerBox.Text);
            Bo2SaveSettingsTool("pubmatchDescBox", pubmatchDescBox.Text);
            Bo2SaveSettingsTool("storeDescBox", storeDescBox.Text);
            Bo2SaveSettingsTool("storeBox", storeBox.Text);
            Bo2SaveSettingsTool("optionsDescBox", optionsDescBox.Text);
            Bo2SaveSettingsTool("optionsBox", optionsBox.Text);
            Bo2SaveSettingsTool("barracksDescBox", barracksDescBox.Text);
            Bo2SaveSettingsTool("barracksBox", barracksBox.Text);
            Bo2SaveSettingsTool("codtvDescBox", codtvDescBox.Text);
            Bo2SaveSettingsTool("codtvBox", codtvBox.Text);
            Bo2SaveSettingsTool("theaterDescBox", theaterDescBox.Text);
            Bo2SaveSettingsTool("theaterBox", theaterBox.Text);
            Bo2SaveSettingsTool("customGameDescBox", customGameDescBox.Text);
            Bo2SaveSettingsTool("customGameBox", customGameBox.Text);
            Bo2SaveSettingsTool("leagueDescBox", leagueDescBox.Text);
            Bo2SaveSettingsTool("leaguePlayBox", leaguePlayBox.Text);
            Bo2SaveSettingsTool("localBox", localBox.Text);
            Bo2SaveSettingsTool("lanPartyBox", lanPartyBox.Text);
            Bo2SaveSettingsTool("playOnlineBox", playOnlineBox.Text);
            Bo2SaveSettingsTool("playersOnlineBox", playersOnlineBox.Text);
            Bo2SaveSettingsTool("addSplitscreenControllerBox", addSplitscreenControllerBox.Text);
            Bo2SaveSettingsTool("backButtonBox", backButtonBox.Text);
            Bo2SaveSettingsTool("friendsPlayingBox", friendsPlayingBox.Text);
            Bo2SaveSettingsTool("scorestreaksDescBox", scorestreaksDescBox.Text);
            Bo2SaveSettingsTool("scorestreaksBox", scorestreaksBox.Text);
            Bo2SaveSettingsTool("createclassDescBox", createclassDescBox.Text);
            Bo2SaveSettingsTool("createaclassBox", createaclassBox.Text);
            Bo2SaveSettingsTool("findmatchDescBox", findmatchDescBox.Text);
            Bo2SaveSettingsTool("findMatchBox", findMatchBox.Text);
            Bo2SaveSettingsTool("livestreamDescBox", livestreamDescBox.Text);
            Bo2SaveSettingsTool("livestreamBox", livestreamBox.Text);
            Bo2SaveSettingsTool("deadScilenceDescBox", deadScilenceDescBox.Text);
            Bo2SaveSettingsTool("deadscilenceBox", deadscilenceBox.Text);
            Bo2SaveSettingsTool("tacMaskDescBox", tacMaskDescBox.Text);
            Bo2SaveSettingsTool("tacMaskBox", tacMaskBox.Text);
            Bo2SaveSettingsTool("engineerDescBox", engineerDescBox.Text);
            Bo2SaveSettingsTool("engineerBox", engineerBox.Text);
            Bo2SaveSettingsTool("exCondDesBox", exCondDesBox.Text);
            Bo2SaveSettingsTool("exCondBox", exCondBox.Text);
            Bo2SaveSettingsTool("dexterityDescBox", dexterityDescBox.Text);
            Bo2SaveSettingsTool("dexterityBox", dexterityBox.Text);
            Bo2SaveSettingsTool("scavengerDescBox", scavengerDescBox.Text);
            Bo2SaveSettingsTool("scavengerBox", scavengerBox.Text);
            Bo2SaveSettingsTool("hardwiredDescBox", hardwiredDescBox.Text);
            Bo2SaveSettingsTool("hardwiredBox", hardwiredBox.Text);
            Bo2SaveSettingsTool("fasthandsDescBox", fasthandsDescBox.Text);
            Bo2SaveSettingsTool("fasthandsBox", fasthandsBox.Text);
            Bo2SaveSettingsTool("coldbloodedDescBox", coldbloodedDescBox.Text);
            Bo2SaveSettingsTool("coldbloodBox", coldbloodBox.Text);
            Bo2SaveSettingsTool("toughnessDescBox", toughnessDescBox.Text);
            Bo2SaveSettingsTool("toughnessBox", toughnessBox.Text);
            Bo2SaveSettingsTool("ghostDescBox", ghostDescBox.Text);
            Bo2SaveSettingsTool("ghostBox", ghostBox.Text);
            Bo2SaveSettingsTool("flakjacketDescBox", flakjacketDescBox.Text);
            Bo2SaveSettingsTool("flakjacketBox", flakjacketBox.Text);
            Bo2SaveSettingsTool("blindeyeDescBox", blindeyeDescBox.Text);
            Bo2SaveSettingsTool("blindeyeBox", blindeyeBox.Text);
            Bo2SaveSettingsTool("hardlineDescBox", hardlineDescBox.Text);
            Bo2SaveSettingsTool("hardlineBox", hardlineBox.Text);
            Bo2SaveSettingsTool("lightweightDescBox", lightweightDescBox.Text);
            Bo2SaveSettingsTool("lightweightBox", lightweightBox.Text);
            Bo2SaveSettingsTool("awarenessDescBox", awarenessDescBox.Text);
            Bo2SaveSettingsTool("awarenessBox", awarenessBox.Text);
            Bo2SaveSettingsTool("c4DescBox", c4DescBox.Text);
            //Bo2SaveSettingsTool("c4box", c4box.Text);
            Bo2SaveSettingsTool("bouncingbettyDescBox", bouncingbettyDescBox.Text);
            Bo2SaveSettingsTool("bouncingbettyBox", bouncingbettyBox.Text);
            Bo2SaveSettingsTool("combataxeDescBox", combataxeDescBox.Text);
            Bo2SaveSettingsTool("combataxeBox", combataxeBox.Text);
            Bo2SaveSettingsTool("semtexDescBox", semtexDescBox.Text);
            Bo2SaveSettingsTool("semtexBox", semtexBox.Text);
            //Bo2SaveSettingsTool("claymoreDescbox", claymoreDescbox.Text);
            Bo2SaveSettingsTool("grenadeDescBox", grenadeDescBox.Text);
            Bo2SaveSettingsTool("claymoreBox", claymoreBox.Text);
            Bo2SaveSettingsTool("grenadeBox", grenadeBox.Text);
            Bo2SaveSettingsTool("tacinsertDescBox", tacinsertDescBox.Text);
            Bo2SaveSettingsTool("tacinsertBox", tacinsertBox.Text);
            Bo2SaveSettingsTool("trophysystemDescBox", trophysystemDescBox.Text);
            Bo2SaveSettingsTool("trophysystemBox", trophysystemBox.Text);
            Bo2SaveSettingsTool("flashbagDescBox", flashbagDescBox.Text);
            Bo2SaveSettingsTool("flashbangBox", flashbangBox.Text);
            Bo2SaveSettingsTool("blackhatDescBox", blackhatDescBox.Text);
            Bo2SaveSettingsTool("blackhatBox", blackhatBox.Text);
            Bo2SaveSettingsTool("shockchargeDescBox", shockchargeDescBox.Text);
            Bo2SaveSettingsTool("shockchargeBox", shockchargeBox.Text);
            Bo2SaveSettingsTool("empgrenadeDescBox", empgrenadeDescBox.Text);
            Bo2SaveSettingsTool("empgrenadeBox", empgrenadeBox.Text);
            Bo2SaveSettingsTool("sensorgrenadeDescBox", sensorgrenadeDescBox.Text);
            Bo2SaveSettingsTool("sensorgrenadeBox", sensorgrenadeBox.Text);
            Bo2SaveSettingsTool("stungrenadeDescBox", stungrenadeDescBox.Text);
            Bo2SaveSettingsTool("stungrenadeBox", stungrenadeBox.Text);
            Bo2SaveSettingsTool("concussionDescBox", concussionDescBox.Text);
            Bo2SaveSettingsTool("concussionBox", concussionBox.Text);
            Bo2SaveSettingsTool("assaultriflesBox", assaultriflesBox.Text);
            Bo2SaveSettingsTool("an94DescBox", an94DescBox.Text);
            Bo2SaveSettingsTool("an94Box", an94Box.Text);
            Bo2SaveSettingsTool("m8a1DescBox", m8a1DescBox.Text);
            Bo2SaveSettingsTool("m8a1Box", m8a1Box.Text);
            Bo2SaveSettingsTool("smrDescBox", smrDescBox.Text);
            Bo2SaveSettingsTool("smrBox", smrBox.Text);
            Bo2SaveSettingsTool("scarDescBox", scarDescBox.Text);
            Bo2SaveSettingsTool("scarhBox", scarhBox.Text);
            Bo2SaveSettingsTool("m27DescBox", m27DescBox.Text);
            Bo2SaveSettingsTool("m27Box", m27Box.Text);
            Bo2SaveSettingsTool("faloswDescBox", faloswDescBox.Text);
            Bo2SaveSettingsTool("faloswBox", faloswBox.Text);
            Bo2SaveSettingsTool("swat556DescBox", swat556DescBox.Text);
            Bo2SaveSettingsTool("swat556Box", swat556Box.Text);
            Bo2SaveSettingsTool("type25DescBox", type25DescBox.Text);
            Bo2SaveSettingsTool("type25Box", type25Box.Text);
            Bo2SaveSettingsTool("mtarDescBox", mtarDescBox.Text);
            Bo2SaveSettingsTool("mtarBox", mtarBox.Text);
            Bo2SaveSettingsTool("m1216DescBox", m1216DescBox.Text);
            Bo2SaveSettingsTool("m1216Box", m1216Box.Text);
            Bo2SaveSettingsTool("ksgDescBox", ksgDescBox.Text);
            Bo2SaveSettingsTool("ksgBox", ksgBox.Text);
            Bo2SaveSettingsTool("s12DescBox", s12DescBox.Text);
            Bo2SaveSettingsTool("s12Box", s12Box.Text);
            Bo2SaveSettingsTool("r870mcsDescBox", r870mcsDescBox.Text);
            Bo2SaveSettingsTool("r870mcsBox", r870mcsBox.Text);
            Bo2SaveSettingsTool("HAMRDescBox", HAMRDescBox.Text);
            Bo2SaveSettingsTool("HAMRBox", HAMRBox.Text);
            Bo2SaveSettingsTool("LSATDescBox", LSATDescBox.Text);
            Bo2SaveSettingsTool("LSATBox", LSATBox.Text);
            Bo2SaveSettingsTool("QBBLSWDescBox", QBBLSWDescBox.Text);
            Bo2SaveSettingsTool("QBBLSWBox", QBBLSWBox.Text);
            Bo2SaveSettingsTool("MK48DescBox", MK48DescBox.Text);
            Bo2SaveSettingsTool("MK48Box", MK48Box.Text);
            Bo2SaveSettingsTool("XPR50DescBox", XPR50DescBox.Text);
            Bo2SaveSettingsTool("XPR50Box", XPR50Box.Text);
            Bo2SaveSettingsTool("BallistaDescBox", BallistaDescBox.Text);
            Bo2SaveSettingsTool("BallistaBox", BallistaBox.Text);
            Bo2SaveSettingsTool("DSR50DescBox", DSR50DescBox.Text);
            Bo2SaveSettingsTool("DSR50Box", DSR50Box.Text);
            Bo2SaveSettingsTool("SVUASDescBox", SVUASDescBox.Text);
            Bo2SaveSettingsTool("SVUASBox", SVUASBox.Text);
            Bo2SaveSettingsTool("assaultshieldDescBox", assaultshieldDescBox.Text);
            Bo2SaveSettingsTool("assaultshieldBox", assaultshieldBox.Text);
            Bo2SaveSettingsTool("partygamesBox", partygamesBox.Text);
            Bo2SaveSettingsTool("combattrainingBox", combattrainingBox.Text);
            Bo2SaveSettingsTool("hardcoreBox", hardcoreBox.Text);
            Bo2SaveSettingsTool("coreBox", coreBox.Text);
            Bo2SaveSettingsTool("playlistsBox", playlistsBox.Text);

            MessageBox.Show("Save was successfull", "Save Successfull.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void SaveMW3Settings()
        {
            MW3SaveSettingsTool("MW3PlayOnlineDescBox", MW3PlayOnlineDescBox.Text);
            MW3SaveSettingsTool("MW3PlayOnlineBox", MW3PlayOnlineBox.Text);
            MW3SaveSettingsTool("MW3MultiplayerBox", MW3MultiplayerBox.Text);
            MW3SaveSettingsTool("MW3MainMenuDescBox", MW3MainMenuDescBox.Text);
            MW3SaveSettingsTool("MW3MainMenuBox", MW3MainMenuBox.Text);
            MW3SaveSettingsTool("MW3OptionsDescBox", MW3OptionsDescBox.Text);
            MW3SaveSettingsTool("MW3OptionsBox", MW3OptionsBox.Text);
            MW3SaveSettingsTool("MW3StoreDescBox", MW3StoreDescBox.Text);
            MW3SaveSettingsTool("MW3StoreBox", MW3StoreBox.Text);
            MW3SaveSettingsTool("MW3VaultDescBox", MW3VaultDescBox.Text);
            MW3SaveSettingsTool("MW3VaultBox", MW3VaultBox.Text);
            MW3SaveSettingsTool("MW3EliteDescBox", MW3EliteDescBox.Text);
            MW3SaveSettingsTool("MW3EliteBox", MW3EliteBox.Text);
            MW3SaveSettingsTool("MW3LanPlayDescBox", MW3LanPlayDescBox.Text);
            MW3SaveSettingsTool("MW3LanPlayBox", MW3LanPlayBox.Text);
            MW3SaveSettingsTool("MW3SplitScreenBox", MW3SplitScreenBox.Text);
            MW3SaveSettingsTool("MW3SplitScreenDescBox", MW3SplitScreenDescBox.Text);
            MW3SaveSettingsTool("MW3AddControllerSplitScreenBox", MW3AddControllerSplitScreenBox.Text);
            MW3SaveSettingsTool("MW3BarracksDescBox", MW3BarracksDescBox.Text);
            MW3SaveSettingsTool("MW3BarracksBox", MW3BarracksBox.Text);
            MW3SaveSettingsTool("MW3CallsignDescBox", MW3CallsignDescBox.Text);
            MW3SaveSettingsTool("MW3CallsignBox", MW3CallsignBox.Text);
            MW3SaveSettingsTool("MW3CreateAClassDescBox", MW3CreateAClassDescBox.Text);
            MW3SaveSettingsTool("MW3CreateAClassBox", MW3CreateAClassBox.Text);
            MW3SaveSettingsTool("MW3PrivateMatchDescBox", MW3PrivateMatchDescBox.Text);
            MW3SaveSettingsTool("MW3PrivateMatchBox", MW3PrivateMatchBox.Text);
            MW3SaveSettingsTool("MW3FindGameDescBox", MW3FindGameDescBox.Text);
            MW3SaveSettingsTool("MW3FindGameBox", MW3FindGameBox.Text);
            MW3SaveSettingsTool("MW3ASSAULTRIFLESBox", MW3ASSAULTRIFLESBox.Text);
            MW3SaveSettingsTool("MW3FADBox", MW3FADBox.Text);
            MW3SaveSettingsTool("MW3AK47Box", MW3AK47Box.Text);
            MW3SaveSettingsTool("MW3MK14Box", MW3MK14Box.Text);
            MW3SaveSettingsTool("MW3ACRBox", MW3ACRBox.Text);
            MW3SaveSettingsTool("MW3G36CBox", MW3G36CBox.Text);
            MW3SaveSettingsTool("MW3TYPE95Box", MW3TYPE95Box.Text);
            MW3SaveSettingsTool("MW3CM901Box", MW3CM901Box.Text);
            MW3SaveSettingsTool("MW3SCARLBox", MW3SCARLBox.Text);
            MW3SaveSettingsTool("MW3M16A4Box", MW3M16A4Box.Text);
            MW3SaveSettingsTool("MW3M4A1Box", MW3M4A1Box.Text);
            MW3SaveSettingsTool("MW3ShotGunsBox", MW3ShotGunsBox.Text);
            MW3SaveSettingsTool("MW3MODEL1887Box", MW3MODEL1887Box.Text);
            MW3SaveSettingsTool("MW3STRIKERBox", MW3STRIKERBox.Text);
            MW3SaveSettingsTool("MW3AA12Box", MW3AA12Box.Text);
            MW3SaveSettingsTool("MW3SPAS12Box", MW3SPAS12Box.Text);
            MW3SaveSettingsTool("MW3KSG12Box", MW3KSG12Box.Text);
            MW3SaveSettingsTool("MW3USAS12Box", MW3USAS12Box.Text);
            MW3SaveSettingsTool("MW3LMGsStringBox", MW3LMGsStringBox.Text);
            MW3SaveSettingsTool("MW3M60E4Box", MW3M60E4Box.Text);
            MW3SaveSettingsTool("MW3MK46Box", MW3MK46Box.Text);
            MW3SaveSettingsTool("MW3PKPPECHENEGBox", MW3PKPPECHENEGBox.Text);
            MW3SaveSettingsTool("MW3MG36Box", MW3MG36Box.Text);
            MW3SaveSettingsTool("MW3L86LSWBox", MW3L86LSWBox.Text);
            MW3SaveSettingsTool("MW3SniperRilesBox", MW3SniperRilesBox.Text);
            MW3SaveSettingsTool("MW3MSRBox", MW3MSRBox.Text);
            MW3SaveSettingsTool("MW3RsassBox", MW3RsassBox.Text);
            MW3SaveSettingsTool("MW3AS50Box", MW3AS50Box.Text);
            MW3SaveSettingsTool("MW3DragunovBox", MW3DragunovBox.Text);
            MW3SaveSettingsTool("MW3L118ABox", MW3L118ABox.Text);
            MW3SaveSettingsTool("MW3Barret50callBox", MW3Barret50callBox.Text);
            MW3SaveSettingsTool("MW3RiotShieldBox", MW3RiotShieldBox.Text);
            MW3SaveSettingsTool("MW3SMGsStringBox", MW3SMGsStringBox.Text);
            MW3SaveSettingsTool("MW3MP7Box", MW3MP7Box.Text);
            MW3SaveSettingsTool("MW3PM9Box", MW3PM9Box.Text);
            MW3SaveSettingsTool("MW3P90Box", MW3P90Box.Text);
            MW3SaveSettingsTool("MW3PP90M1Box", MW3PP90M1Box.Text);
            MW3SaveSettingsTool("MW3UMP45Box", MW3UMP45Box.Text);
            MW3SaveSettingsTool("MW3MP5Box", MW3MP5Box.Text);
            MW3SaveSettingsTool("MW3MachinePistolsBox", MW3MachinePistolsBox.Text);
            MW3SaveSettingsTool("MW3G18Box", MW3G18Box.Text);
            MW3SaveSettingsTool("MW3SkorpionBox", MW3SkorpionBox.Text);
            MW3SaveSettingsTool("MW3MP9Box", MW3MP9Box.Text);
            MW3SaveSettingsTool("MW3FMG9Box", MW3FMG9Box.Text);
            MW3SaveSettingsTool("MW3DesertEagleBox", MW3DesertEagleBox.Text);
            MW3SaveSettingsTool("MW3HandGunsBox", MW3HandGunsBox.Text);
            MW3SaveSettingsTool("MW3FiveSevenBox", MW3FiveSevenBox.Text);
            MW3SaveSettingsTool("MW344MagnumBox", MW344MagnumBox.Text);
            MW3SaveSettingsTool("MW3MP412Box", MW3MP412Box.Text);
            MW3SaveSettingsTool("MW3P99Box", MW3P99Box.Text);
            MW3SaveSettingsTool("MW3USP45Box", MW3USP45Box.Text);
            MW3SaveSettingsTool("MW3LaunchersBox", MW3LaunchersBox.Text);
            MW3SaveSettingsTool("MW3RPG7Box", MW3RPG7Box.Text);
            MW3SaveSettingsTool("MW3M320GLMBox", MW3M320GLMBox.Text);
            MW3SaveSettingsTool("MW3XM25Box", MW3XM25Box.Text);
            MW3SaveSettingsTool("MW3StingerBox", MW3StingerBox.Text);
            MW3SaveSettingsTool("MW3JavelinBox", MW3JavelinBox.Text);
            MW3SaveSettingsTool("MW3SMAWBox", MW3SMAWBox.Text);

        }
        
        /// Load JSON File
        public  void LoadBo2Settings()
        {
            Bo2LoadSettingsTool();
            MessageBox.Show("Custom Config File loaded :)","Load Successfull",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Data/Bo2ToolSettings.json"))
                File.Delete("Data/Bo2ToolSettings.json");

            SaveBo2Settings();
            MessageBox.Show("Custom Config File Saved :)", "Load Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BO2LoadSettings_Click(object sender, EventArgs e)
        {
            LoadBo2Settings();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MW3LoadSettingsTool();
            MessageBox.Show("Custom Config File loaded :)", "Load Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (File.Exists("Data/MW3ToolSettings.json"))
                File.Delete("Data/MW3ToolSettings.json");

            SaveMW3Settings();
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
            NEWS();
            tabControl2.Enabled = true;
            tabControlMW3.Enabled = true;
            tabControlBO2.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            threadIsRunning = false;
            TargetInfo.Abort();
            FuncDank.PS3Setting.PS3.DisconnectTarget();
        }

        #region Connection / PS3 Misc
        //CLEAR MEMORY * i know there is probably a better way to do this but dont forget, im a fucking noob.

        private void InfoWorker()
        {
            CCAPIFirmwareLbl.Invoke((MethodInvoker)(() => { CCAPIFirmwareLbl.Text = FuncDank.PS3Setting.PS31.GetFirmwareVersion(); }));
            CCAPIConsoleTypeLbl.Invoke((MethodInvoker)(() => { CCAPIConsoleTypeLbl.Text = FuncDank.PS3Setting.PS31.GetFirmwareType(); }));
            while (threadIsRunning)
            {
                string temp1 = FuncDank.PS3Setting.PS31.GetTemperatureCELL();
                string temp2 = FuncDank.PS3Setting.PS31.GetTemperatureRSX();
                CCAPICELLTempLbl.Invoke((MethodInvoker)(() => { CCAPICELLTempLbl.Text = temp1; }));
                CCAPIRSXTempLbl.Invoke((MethodInvoker)(() => { CCAPIRSXTempLbl.Text = temp2; }));
                FuncDank.PS3Setting.PS31.ClearTargetInfo();
                Thread.Sleep(500);
            }
            TargetInfo.Abort();
        }

  
        public void CCAPIComboBoxUpdates()
        {
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.INFO);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.CAUTION);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.FRIEND);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.SLIDER);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.WRONGWAY);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.DIALOG);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.DIALOGSHADOW);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.TEXT);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.POINTER);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.GRAB);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.HAND);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.PEN);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.FINGER);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.ARROW);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.ARROWRIGHT);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.PROGRESS);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.TROPHY1);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.TROPHY2);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.TROPHY3);
            CCAPINotifyIconComboBox.Items.Add(CCAPI.NotifyIcon.TROPHY4);

            CCAPIBuzzerComboBox.Items.Add(CCAPI.BuzzerMode.Continuous);
            CCAPIBuzzerComboBox.Items.Add(CCAPI.BuzzerMode.Single);
            CCAPIBuzzerComboBox.Items.Add(CCAPI.BuzzerMode.Double);



        }

        private void CCAPIBuzzerBtn_Click(object sender, EventArgs e)
        {
            FuncDank.PS3Setting.PS31.RingBuzzer((CCAPI.BuzzerMode)CCAPIBuzzerComboBox.SelectedIndex);

        }

        //CCAPI
        private void ccapiToolStrip_Click(object sender, EventArgs e)
        {
            FuncDank.PS3Setting.PS3.ChangeAPI(SelectAPI.ControlConsole);
            try
            {
                StatusLabel.Text = "Connecting With CCAPI";
                if (FuncDank.PS3Setting.PS3.ConnectTarget(0))
                {
                    StatusLabel.Text = "Conneced With CCAPI Successfully";
                    string Message = "You are now connected with this API : " + FuncDank.PS3Setting.PS3.GetCurrentAPIName();
                    FuncDank.PS3Setting.PS31.Notify(CCAPI.NotifyIcon.HAND, "Connected To Kronos's BO2 Tool, \r\n Thanks For Using :)");
                    FuncDank.PS3Setting.PS31.RingBuzzer(CCAPI.BuzzerMode.Single);
                  //  MessageBox.Show(Message, "Connected!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ConnectedStripLabel.ForeColor = Color.Green;
                    ConnectedStripLabel.Text = "Connected";
                    //+ccapiIP = FuncDank.PS3Setting.PS31.
                    CCAPIComboBoxUpdates();
                    isConnected = true;



                }
                else
                {
                    StatusLabel.Text = "Connecting with CCAPI Failed";
                    string Message = "Impossible to connect :/";
                    MessageBox.Show(Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AttachStripLabel.ForeColor = Color.Yellow;
                    AttachStripLabel.Text = "Error Connecting...";
                }
            }
            catch
            {

            }
        }

      
        public void GetCurrentGameName()
        {
            string outstring;
            uint process = FuncDank.PS3Setting.PS31.GetAttachedProcess();
            FuncDank.PS3Setting.PS31.GetProcessName(process, out outstring);
            //MessageBox.Show(outstring);
            if (outstring.Contains("BLES01717") || outstring.Contains("BLES01718") || outstring.Contains("BLES01719") || outstring.Contains("BLES01720") || outstring.Contains("BLUS31011") || outstring.Contains("BLUS31140") || outstring.Contains("BLUS31141"))
            {
                CurrentGame = " | Current Game: Black Ops 2";
                tabControlBO2.Enabled = true;
                //tabControlMW3.Enabled = true;
            }
            else if (outstring.Contains("BLES01428") || outstring.Contains("BLES01718") || outstring.Contains("BLES01719") || outstring.Contains("BLES01720") || outstring.Contains("BLUS31011") || outstring.Contains("BLUS31140") || outstring.Contains("BLUS31141"))
            {
                CurrentGame = " | Current Game: Modern Warfare 3";
                tabControlMW3.Enabled = true;
               // tabControlBO2.Enabled = true;
            }
            //string MW3 = FuncDank.PS3Setting.PS3.Extension.ReadString(0x318C9AB1);
            //string BO2 = FuncDank.PS3Setting.PS3.Extension.ReadString(0x3091F6D0);
            ////if (MW3 == "Modern Warfare 3") { CurrentGame = " Current Game: Modern Warfare 3"; tabControlMW3.Enabled = true; }
            ////if (BO2 == "BLACK OPS 2") { CurrentGame = " Current Game: Black Ops 2"; tabControlBO2.Enabled = true; }
            Form1.ActiveForm.Text += CurrentGame;


        }

        //ATTACH
        private void attachToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                
                StatusLabel.Text = "Attempting to Attach to Game Process";
                if (FuncDank.PS3Setting.PS3.AttachProcess())
                {
                    StatusLabel.Text = "Attaching to Game Process Successfull";
                    FuncDank.PS3Setting.PS31.RingBuzzer(CCAPI.BuzzerMode.Double);
                    FuncDank.PS3Setting.PS31.Notify(CCAPI.NotifyIcon.TROPHY4, "Succesfully Attached to Kronos's Multi-Cod String Tool \n\nHave Fun Modding :)");
                //    MessageBox.Show("Current game is attached successfully.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AttachStripLabel.ForeColor = Color.Green;
                    AttachStripLabel.Text = "Attached";
                    tabControl2.Enabled = true;
                    GetCurrentGameName();
                    
                    
                   
                }
                else
                {
                    StatusLabel.Text = "Attaching Failed";
                    MessageBox.Show("No game process found!", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AttachStripLabel.ForeColor = Color.Yellow;
                    AttachStripLabel.Text = "Error Attaching...";
                }
            }
            catch
            {

            }
        }
        
        //SYSTEM INFO
        private void pS3InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Getting PS3 System Info";
            string ps3info = $"Firmware Version: {FuncDank.PS3Setting.PS31.GetFirmwareVersion()}    Firmware Type: {FuncDank.PS3Setting.PS31.GetFirmwareType()}\n\nCell Temp:   {FuncDank.PS3Setting.PS31.GetTemperatureCELL()}              RSX Temp:   {FuncDank.PS3Setting.PS31.GetTemperatureRSX()}";
            MessageBox.Show(ps3info,"System Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
            StatusLabel.Text = "PS3 Info Gotten";
        }

        //Shutdown PS3
        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncDank.PS3Setting.PS31.ShutDown(CCAPI.RebootFlags.ShutDown);
        }

        //Soft Reboot PS3
        private void softRebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncDank.PS3Setting.PS31.ShutDown(CCAPI.RebootFlags.SoftReboot);
        }

        //Hard Reboot PS3
        private void hardRebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncDank.PS3Setting.PS31.ShutDown(CCAPI.RebootFlags.HardReboot);
        }

        //Notify
        private void CCAPINotifyBtn_Click(object sender, EventArgs e)
        {
            FuncDank.PS3Setting.PS31.Notify(CCAPINotifyIconComboBox.SelectedIndex, CCAPINotifyBox.Text);
        }

        private void CCAPIShutdownBtn_Click(object sender, EventArgs e)
        {
            FuncDank.PS3Setting.PS31.ShutDown(CCAPI.RebootFlags.ShutDown);
        }

        private void CCAPISoftRebootBtn_Click(object sender, EventArgs e)
        {
            FuncDank.PS3Setting.PS31.ShutDown(CCAPI.RebootFlags.SoftReboot);
        }

        private void CCAPIHardRebootBtn_Click(object sender, EventArgs e)
        {
            FuncDank.PS3Setting.PS31.ShutDown(CCAPI.RebootFlags.HardReboot);
        }

        private void CCAPIRefreshTempsBtn_Click(object sender, EventArgs e)
        {
            if (isConnected == true)
            {
                if (!TargetInfo.IsAlive)
                {
                    threadIsRunning = true;
                    TargetInfo.Start();
                }
            }
            else
            {
                MessageBox.Show("Please Connect with CCAPI first!", "Error please connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CCAPIDisconnectBtn_Click(object sender, EventArgs e)
        {
            FuncDank.PS3Setting.PS3.DisconnectTarget();
        }

        #endregion

        #region BlackOps 2
        #region Multiplayer Menu
        #region Game Options

        //String: PLAY ONLINE
        private void playOnlineBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.PlayOnline(playOnlineBox.Text);
            StatusLabel.Text = "'PLAYONLINE' String Successfully Changed";
            
        }

        //String: LAN PARTY
        private void lanPartyBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.LanParty(lanPartyBox.Text);
            StatusLabel.Text = "'LAN PARTY' String Successfully Changed";

        }

        //String: LOCAL
        private void localBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.Local(localBox.Text);
            StatusLabel.Text = "'LOCAL' String Successfully Changed";
        }
        
        //String: MULTIPLAYER
        private void MultiplayerBtn_Click(object sender, EventArgs e) 
        {
            BO2.MuliplayerMenu.Muliplayer(multiplayerBox.Text);
            StatusLabel.Text = "'MULTIPLAYER' String Successfully Changed";
        }

        //String: PUBLIC MATCH
        private void pubMatchBtn_Click(object sender, EventArgs e) 
        {
            BO2.MuliplayerMenu.PublicMatch(pubmatchBox.Text);
            StatusLabel.Text = "'PUBLIC MATCH' String Successfully Changed";
        }

        //String: Play online to earn Experience (XP) and rewards. 
        private void button1_Click_1(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.PublicMatchDesc(pubmatchDescBox.Text);
            StatusLabel.Text = "Pub Match Desc String Successfully Changed";

        }

        //String: LEAGUE PLAY
        private void leaguePlayBtn_Click(object sender, EventArgs e) 
        {
            BO2.MuliplayerMenu.LeaguePLay(leaguePlayBox.Text);
            StatusLabel.Text = "League Play String Successfully Changed";
        }

        //String: Find opponents at your skill level and battle for top position in League Ladders
        private void leagueDescBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.LeaguePLayDesc(leagueDescBox.Text);
            StatusLabel.Text = "League Play Desc String Successfully Changed";
        }

        //String: CUSTOM GAMES
 
        private void customGameBtn_Click(object sender, EventArgs e) 
        {
            BO2.MuliplayerMenu.CustomGame(customGameBox.Text);

            StatusLabel.Text = "CUSTOM GAMES String Successfully Changed";

        }

        //String: Create a match to play with your friends. Save and share your own custom game rules.
        private void customgameDescBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.CustomGameDesc(customGameDescBox.Text);
            StatusLabel.Text = "Custom Game Desc String Successfully Changed";

        }

        //String: THEATER
        private void theaterBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.Theater(theaterBox.Text);
            StatusLabel.Text = "THEATER String Successfully Changed";

        }

        //String: Watch Films with your friends, and create Clips to share with the community.
        private void theaterDescBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.TheaterDesc(theaterDescBox.Text);
            StatusLabel.Text = "Theater Desc String Successfully Changed";

        }

        //String: COD TV
        private void codtvBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.CodTv(codtvBox.Text);
            StatusLabel.Text = "COD TV String Successfully Changed";

        }

        //String: Browse official Call of Duty videos and the best content from the community. 
        private void codtvDescBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.CodTvDesc(codtvDescBox.Text);
            StatusLabel.Text = "COD TV Desc String Successfully Changed";

        }

        //String: BARRACKS
        private void barracksBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.Barracks(barracksBox.Text);
            StatusLabel.Text = "BARRACKS String Successfully Changed";

        }

        //String: Edit your Playercard, browse Challenges, view your Combat Record and more.
        private void barracksDescBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.BarracksDesc(barracksDescBox.Text);
            StatusLabel.Text = "BARRACKS Desc String Successfully Changed";

        }

        //String: OPTIONS
        private void optionsBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.Options(optionsBox.Text);
            StatusLabel.Text = "OPTIONS String Successfully Changed";

        }

        //String: Edit your game, audio and display settings.
        private void optionsDescBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.OptionsDesc(optionsDescBox.Text);
            StatusLabel.Text = "OPTIONS Desc String Successfully Changed";

        }

        //String: STORE
        private void storeBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.Store(storeBox.Text);
            StatusLabel.Text = "STORE String Successfully Changed";

        }

        //String: Browse the Store for avatars, themes, downloadable content and more.
        private void storeDescBtn_Click_1(object sender, EventArgs e)
        {
            BO2.MuliplayerMenu.StoreDesc(storeDescBox.Text);
            StatusLabel.Text = "STORE Desc String Successfully Changed";
        }
        #endregion

        #region Multiplayer Menu Misc
        //String: Add Controller For Split Screen
        private void controllerSplitScreenBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenuMisc.ControllerSplitSCreen(addSplitscreenControllerBox.Text);
            StatusLabel.Text = "Add Controller String Successfully Changed";

        }

        //String: PLayers Online
        private void playersOnlineBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenuMisc.PlayersOnline(playersOnlineBox.Text);
            StatusLabel.Text = "Players Online String Successfully Changed";
        }

        //String: Back
        private void backButtonBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenuMisc.BackButton(backButtonBox.Text);
            StatusLabel.Text = "Players Online String Successfully Changed";
        }

        //String: Friends Playing Black Ops II
        private void friendsPlayingBtn_Click(object sender, EventArgs e)
        {
            BO2.MuliplayerMenuMisc.FriendsPlaying(friendsPlayingBox.Text);
            StatusLabel.Text = "Players Online String Successfully Changed";
        }
        #endregion
        #endregion

        #region Public Match Menu
        //String: Find Match
        private void findmatchBtn_Click(object sender, EventArgs e)
        {
            BO2.PublicMatch.FindMatch(findMatchBox.Text);
            StatusLabel.Text = "FIND MATCH String Successfully Changed";
        }

        //String: Pick a game mode and join a match online.
        private void findmatchDescBtn_Click(object sender, EventArgs e)
        {
            BO2.PublicMatch.FindMatchDesc(findMatchBox.Text);
            StatusLabel.Text = "Find match Desc String Successfully Changed";
        }

        //String: Create A Class
        private void createaclassBtn_Click(object sender, EventArgs e)
        {
            BO2.PublicMatch.CreateAClass(createaclassBox.Text);
            StatusLabel.Text = "CREATE A CLASS String Successfully Changed";
        }

        //String: Customize your loadout.
        private void createaclassDescBtn_Click(object sender, EventArgs e)
        {
            BO2.PublicMatch.CreateAClassDesc(createclassDescBox.Text);
            StatusLabel.Text = "Create a class Desc String Successfully Changed";
        }

        //String: SCORESTREAKS
        private void scorestreaksBtn_Click(object sender, EventArgs e)
        {
            BO2.PublicMatch.ScoreStreaks(scorestreaksBox.Text);
            StatusLabel.Text = "SCORESTREAK String Successfully Changed";
        }

        //String: Customize your Scorestreak rewards.
        private void scorestreaksDescBtn_Click(object sender, EventArgs e)
        {
            BO2.PublicMatch.ScoreStreaksDesc(scorestreaksDescBox.Text);
            StatusLabel.Text = "Scorestreak Desc String Successfully Changed";
        }

        //String: LIVESTREAM
        private void livestreamBtn_Click(object sender, EventArgs e)
        {
            BO2.PublicMatch.LiveStream(livestreamBox.Text);
            StatusLabel.Text = "LIVESTREAM String Successfully Changed";
        }

        //String: Stream your game live to the internet.
        private void livestreamDescBtn_Click(object sender, EventArgs e)
        {
            BO2.PublicMatch.LiveStreamDesc(livestreamDescBox.Text);
            StatusLabel.Text = "Livestream Desc String Successfully Changed";

        }
        #endregion

        #region Create A Class Menu

        #region Perks


        //String: Lightweight
        private void lightweightBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.LightWeight(lightweightBox.Text);
            StatusLabel.Text = "LightWeight String Successfully Changed";
        }

        //String: Move faster. Take no damamge when falling
        private void lightweightDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.LightWeightDesc(lightweightDescBox.Text);
            StatusLabel.Text = "LightWeightDesc String Successfully Changed";
        }

        //String: Hardline
        private void hardlineBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.Hardline(hardlineBox.Text);
            StatusLabel.Text = "Hardline String Successfully Changed";
        }

        //String: Earn Scorestreaks Faster
        private void hardlineDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.HardlineDesc(hardlineDescBox.Text);
            StatusLabel.Text = "HardlineDesc String Successfully Changed";
        }

        //String: Blind Eye
        private void blindeyeBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.BlindEye(blindeyeBox.Text);
            StatusLabel.Text = "BlindEye String Successfully Changed";
        }

        //String: Undetectable by AI controlled air support
        private void blindeyeDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.BlindEyeDesc(blindeyeBox.Text);
            StatusLabel.Text = "BlindEyeDesc String Successfully Changed";
        }

        //String: Flak Jacket
        private void flakjacketBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.FlakJacket(flakjacketBox.Text);
            StatusLabel.Text = "FlakJacket String Successfully Changed";
        }

        //String: Take less Explosive damage
        private void flakjacketDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.FlackJacketDesc(lightweightDescBox.Text);
            StatusLabel.Text = "FlackJacketDesc String Successfully Changed";
        }

        //String: Ghost
        private void ghostBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.Ghost(ghostBox.Text);
            StatusLabel.Text = "Ghost String Successfully Changed";
        }

        //String: Cannot be detected by enemy UAV's while moving, planting or defusing bombs, or while controlling score streaks.
        private void ghostDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.GhostDesc(ghostDescBox.Text);
            StatusLabel.Text = "GhostDesc String Successfully Changed";
        }

        //String: Toughness
        private void toughnessBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.Toughness(toughnessBox.Text);
            StatusLabel.Text = "Toughness String Successfully Changed";
        }

        //String: Flitch Less when shot
        private void toughnessDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.ToughnessDesc(toughnessDescBox.Text);
            StatusLabel.Text = "ToughnessDesc String Successfully Changed";
        }

        //String: Cold Blooded
        private void coldbloodedBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.ColdBlooded(coldbloodBox.Text);
            StatusLabel.Text = "ColdBlooded String Successfully Changed";
        }

        //String: Resistant to targeting Systems Etc
        private void coldbloodedDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.ColdBloodedDesc(coldbloodedDescBox.Text);
            StatusLabel.Text = "ColdBloodedDesc String Successfully Changed";
        }

        //String: Fast Hands
        private void fasthandsBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.FastHands(fasthandsBox.Text);
            StatusLabel.Text = "FastHands String Successfully Changed";
        }

        //String: Swap Weapons faster and use equipment faster
        private void fasthandsDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.FastHandsDesc(fasthandsDescBox.Text);
            StatusLabel.Text = "FastHandsDesc String Successfully Changed";
        }

        //String: Hard Wired
        private void hardwiredBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.HardWired(hardwiredBox.Text);
            StatusLabel.Text = "HardWired String Successfully Changed";
        }

        //String: Immune to Counter-UAV and EMP.
        private void hardwiredDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.HardWiredDesc(hardwiredDescBox.Text);
            StatusLabel.Text = "HardWiredDesc String Successfully Changed";
        }

        //String: Scavenger
        private void scavengerBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.Scavenger(scavengerBox.Text);
            StatusLabel.Text = "Scavenger String Successfully Changed";
        }

        //String: Replenish ammo and equipment from enemies killed by non-explosive weapons.
        private void scavengerDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.ScavengerDesc(scavengerDescBox.Text);
            StatusLabel.Text = "ScavengerDesc String Successfully Changed";
        }

        //String: Dexterity
        private void dexterityBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.Dexterity(dexterityBox.Text);
            StatusLabel.Text = "Dexterity String Successfully Changed";
        }

        //String: Aim faster after sprinting. Mantle and climb faster. 
        private void dexterityDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.DexterityDesc(dexterityDescBox.Text);
            StatusLabel.Text = "DexterityDesc String Successfully Changed";
        }

        //String: Extreme Conditioning
        private void extCondBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.ExtremeConditioning(exCondBox.Text);
            StatusLabel.Text = "ExtremeConditioning String Successfully Changed";
        }

        //String: Sprint for a longer duration
        private void extConDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.ExtremeConditioningDesc(exCondDesBox.Text);
            StatusLabel.Text = "ExtremeConditioningDesc String Successfully Changed";
        }

        //String: Engineer
        private void engineerBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.Engineer(engineerBox.Text);
            StatusLabel.Text = "Engineer String Successfully Changed";
        }

        //String: Show enemy equipment in the world.  Delay triggered explosives. Reroll and booby trap Care Packages.
        private void engineerDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.EngineerDesc(engineerDescBox.Text);
            StatusLabel.Text = "EngineerDesc String Successfully Changed";
        }

        //String: Tactical Mask
        private void tacmaskBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.TacticalMask(tacMaskBox.Text);
            StatusLabel.Text = "TacticalMask String Successfully Changed";
        }

        //String: Reduce the effects of Flashbangs, Concussion Grenades, and Shock Charges.
        private void tacmaskDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.TacticalMaskDesc(tacMaskDescBox.Text);
            StatusLabel.Text = "TacticalMaskDesc String Successfully Changed";
        }

        //String: Dead Silence
        private void deadscilenceBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.DeadSilence(deadscilenceBox.Text);
            StatusLabel.Text = "DeadSilence String Successfully Changed";
        }

        //String: Move Silently
        private void deadscilenceDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.DeadSilenceDesc(deadScilenceDescBox.Text);
            StatusLabel.Text = "DeadSilenceDesc String Successfully Changed";
        }

        //String: Awareness 
        private void awarenessBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.Awareness(awarenessBox.Text);
            StatusLabel.Text = "Awareness String Successfully Changed";
        }

        //String: Enemy movements are easier to hear.
        private void awarenessDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Perks.AwarenessDesc(awarenessDescBox.Text);
            StatusLabel.Text = "AwarenessDesc String Successfully Changed";
        }


        #endregion

        #region Lethals / Tactials 

        //String: Grenade
        //Free Mem:0x51002760  | Pointer: 0x013476A4  | Origional Offset: 0x308f0957
        private void grenadeBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.Grenade(grenadeBox.Text);
        }

        //String: Produces lethal radius damage upon detonation.
        //Free Mem:0x510027D0 | Pointer: 0x013476AC  | Origional Offset: 0x308F0972
        private void grenadeDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.GrenadeDesc(grenadeDescBox.Text);
        }

        //String: Semtex
        //Free Mem:0x51002840  | Pointer: 0x01347AEC  | Origional Offset: 0x308F1F55
        private void semtexBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.Semtex(semtexBox.Text);
        }

        //String: Grenade that sticks to surfaces before detonating.
        //Free Mem:0x510028B0  | Pointer: 0x01347AF4  | Origional Offset: 0x308F1F72
        private void semtexDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.SemtexDesc(semtexDescBox.Text);
        }

        //String: Combat Axe
        //Free Mem:0x51002920  | Pointer: 0x01347754  | Origional Offset: 0x308F0CA7
        private void combataxeBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.CombatAxe(combataxeBox.Text);
        }

        //String: Retrievable axe that causes instant death on impact.
        //Free Mem:0x51002990 | Pointer: 0x0134775C  | Origional Offset: 0x308F0CC1
        private void combataxeDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.CombatAxeDesc(combataxeDescBox.Text);
        }

        //String: Bouncing Betty
        //Free Mem:0x51002A00 | Pointer: 0x013476B4  | Origional Offset: 0x308F09B9
        private void bouncingbettyBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.Bouncingbetty(bouncingbettyBox.Text);
        }

        //String: Proximity mine that launches into the air before detonating.  Can be avoided by crouching or going prone.
        //Free Mem:0x51002A70  | Pointer: 0x01348F5C  | Origional Offset: 0x308F8B5B
        private void bouncingbettyDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.BouncingbettyDesc(bouncingbettyDescBox.Text);
        }

        //String: C4
        //Free Mem:0x51002AE0  | Pointer: 0x  | Origional Offset: 0x3
        private void c4Btn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.C4(c4box.Text);
        }

        //String: A plastic explosive device that is detonated remotely by double-tapping ^BBUTTON_INTERACT^.
        //Free Mem:0x51002B50  | Pointer: 0x0134707C  | Origional Offset: 0x308ED427
        private void c4descBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.C4Desc(c4DescBox.Text);
        }

        //String: Claymore
        //Free Mem:0x51002BC0  | Pointer: 0x013475FC  | Origional Offset: 0x308F055D
        private void claymoreBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.Claymore(claymoreBox.Text);
        }

        //String: Directional anti-personnel mine that triggers a proximity-based explosion.
        //Free Mem:0x51002C30  | Pointer: 0x01347604  | Origional Offset: 0x308F0576
        private void claymoreDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.ClaymoreDesc(claymoreDescbox.Text);
        }

        //String: Concusstion
        //Free Mem:0x51002CA0  | Pointer: 0x01347AFC  | Origional Offset: 0x308F1FC0
        private void concussionBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.Concussion(concussionBox.Text);
        }

        //String:Disorients enemies and slows movement.
        //Free Mem:0x51002D10  | Pointer: 0x01347B04  | Origional Offset: 0x308F1FDF
        private void concussionDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.ConcussionDesc(concussionDescBox.Text);
        }

        //String: Smoke Grenade
        //Free Mem:0x51002D80  | Pointer: 0x01347BC4  | Origional Offset: 0x308F1E58
        private void stungrenadeBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.StunGrenade(stungrenadeBox.Text);
        }

        //String: Produces a smoke screen immediately upon impact.
        //Free Mem:0x51002DF0  | Pointer: 0x01347BCC  | Origional Offset: 0x308F23EC
        private void stungrenadeDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.StungrGenadeDesc(stungrenadeDescBox.Text);
        }

        //String: Sensor Grenade
        //Free Mem:0x51002E60  | Pointer: 0x01348F7C  | Origional Offset: 0x308F8C94
        private void sensorgrenadeBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.SensorGrenade(sensorgrenadeBox.Text);
        }

        //String: Detects enemy soldiers within line of sight.
        //Free Mem:0x51002ED0  | Pointer: 0x01348F84  | Origional Offset: 0x308F8CB9
        private void sensorgrenadeDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.SensorGrenadeDesc(sensorgrenadeDescBox.Text);
        }

        //String: EMP Grenade
        //Free Mem:0x51002F40  | Pointer: 0x01347EAC  | Origional Offset: 0x308F3516
        private void empgrenadeBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.EmpGrenade(empgrenadeBox.Text);
        }

        //String: Disables nearby enemy electronic systems .
        //Free Mem:0x51002FB0  | Pointer: 0x01347EB4  | Origional Offset: 0x308F3534
        private void empgrenadeDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.EmpGrenadeDesc(empgrenadeDescBox.Text);
        }

        //String: Shock Charge
        //Free Mem:0x51003020  | Pointer: 0x01347F3C  | Origional Offset: 0x308F3865
        private void shockchargeBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.ShockCharge(shockchargeBox.Text);
        }

        //String: Proximity triggered mine that electrocutes and stuns nearby enemies.
        //Free Mem:0x51003090  | Pointer: 0x01347F44 | Origional Offset: 0x308F388B
        private void shockchargeDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.ShockChargeDesc(shockchargeDescBox.Text);
        }

        //String: Black Hat
        //Free Mem:0x51003100  | Pointer: 0x01349094 | Origional Offset: 0x308F9021
        private void blackhatBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.Blackhat(blackhatBox.Text);
        }

        //String: Hack equipment and care packages, or disable enemy vehicles.
        //Free Mem:0x51003170  | Pointer: 0x0134909C  | Origional Offset: 0x308F903B 
        private void blackhatDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.BlackhatDesc(blackhatDescBox.Text);
        }

        //String: Flash Bang
        //Free Mem:0x510031E0  | Pointer: 0x01347684 | Origional Offset: 0x308F08A2
        private void flashbangBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.Flashbang(flashbangBox.Text);
        }

        //String: Blinds enemies and impairs hearing.
        //Free Mem:0x51003250  | Pointer: 0x0134768C  | Origional Offset: 0x308F08BD
        private void flashbangDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.FlashbangDesc(flashbagDescBox.Text);
        }

        //String: Trophy System
        //Free Mem:0x510032C0  | Pointer: 0x01348F6C  | Origional Offset: 0x308F8BF4
        private void trophysystemBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.TrophySystem(trophysystemBox.Text);
        }

        //String: Destroys incoming enemy projectiles within 10 meters. Vehicle missiles have a chance to penetrate.
        //Free Mem:0x51003330  | Pointer: 0x01348F74  | Origional Offset: 0x308F8C17
        private void trophysystemDescbtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.TrophySystemDesc(trophysystemDescBox.Text);
        }


        private void tacinsertBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.TacInsert(tacinsertBox.Text);
        }

        //String: Tactical Insertion
        //Free Mem:0x510033A0  | Pointer: 0x01347B24  | Origional Offset: 0x308F2088
        private void tacinsertDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LethalsTacticals.TacInsertDesc(tacinsertDescBox.Text);
        }


        #endregion

        #region AssaultRifles

        private void mtarBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.MTAR(mtarBox.Text);
        }


        private void mtarDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.MTARDesc(mtarDescBox.Text);
        }

        private void type25Btn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.Type25(type25Box.Text);
        }

        private void type25DescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.Type25Desc(type25DescBox.Text);
        }

        private void swat556Btn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.SWAT556(swat556Box.Text);
        }

        private void swat556DescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.SWAT556Desc(swat556DescBox.Text);
        }

        private void faloswBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.FALOSW(faloswBox.Text);
        }

        private void faloswDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.FALOSWDesc(faloswDescBox.Text);
        }

        private void m27Btn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.M27(m27Box.Text);
        }

        private void m27DescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.M27Desc(m27DescBox.Text);
        }

        private void scarhBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.SCARH(scarhBox.Text);
        }

        private void scarhDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.SCARHDesc(scarDescBox.Text);
        }

        private void smrBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.SMR(smrBox.Text);
        }

        private void smrDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.SMRDesc(smrDescBox.Text);
        }

        private void m8a1Btn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.M8A1(m8a1Box.Text);
        }

        private void m8a1DescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.M8A1Desc(m8a1DescBox.Text);
        }

        private void an94Btn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.AN94(an94Box.Text);
        }

        private void an94DescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.AN94Desc(an94DescBox.Text);
        }

        private void assaultriflesBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.AssultRifles.AssaultFiles(assaultriflesBox.Text);
        }
        #endregion

        #region Shotuns

        private void r870mcsBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Shotguns.R870MCS(r870mcsBox.Text);
        }

        private void r870mcsDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Shotguns.R870MCSDesc(r870mcsDescBox.Text);
        }

        private void s12Btn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Shotguns.S12(s12Box.Text);
        }

        private void s12DescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Shotguns.S12Desc(s12DescBox.Text);
        }

        private void ksgBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Shotguns.KSG(ksgBox.Text);
        }

        private void ksgDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Shotguns.KSGDesc(ksgDescBox.Text);
        }

        private void m1216Btn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Shotguns.M1216(m1216Box.Text);
        }

        private void m1216DescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Shotguns.M1216Desc(m1216DescBox.Text);
        }
        #endregion

        #region LMGs
        private void MK48Btn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LMGs.MK48(MK48Box.Text);
        }

        private void MK48DescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LMGs.MK48Desc(MK48DescBox.Text);
        }

        private void QBBLSWBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LMGs.QBBLSW(QBBLSWBox.Text);
        }

        private void QBBLSWDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LMGs.QBBLSWDesc(QBBLSWDescBox.Text);
        }

        private void LSATBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LMGs.LSAT(LSATBox.Text);
        }

        private void LSATDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LMGs.LSATDesc(LSATDescBox.Text);
        }

        private void HAMRBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LMGs.HAMR(HAMRBox.Text);
        }

        private void HAMRDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.LMGs.HAMRDesc(HAMRDescBox.Text);
        }
        #endregion

        #region Snipers
        private void SVUASBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Sniper.SVUAS(SVUASBox.Text);
        }

        private void SVUASDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Sniper.SVUASDesc(SVUASDescBox.Text);
        }

        private void DSR50Btn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Sniper.DSR50(DSR50Box.Text);
        }

        private void DSR50DescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Sniper.DSR50Desc(DSR50DescBox.Text);
        }

        private void BallistaBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Sniper.Ballista(BallistaBox.Text);
        }

        private void BallistaDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Sniper.BallistaDesc(BallistaDescBox.Text);
        }

        private void XPR50Btn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Sniper.XPR50(XPR50Box.Text);
        }

        private void XPR50DescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.Sniper.XPR50Desc(XPR50DescBox.Text);
        }

        #endregion

        #region Specials 
        private void assaultshieldBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.PrimarySpecial.AssaultShield(assaultshieldBox.Text);

        }

        private void assaultshieldDescBtn_Click(object sender, EventArgs e)
        {
            BO2.CreateAClass.PrimarySpecial.AssaultShield(assaultshieldDescBox.Text);

        }




        #endregion

        #endregion

        #region PlayLists

        private void playlistsBtn_Click(object sender, EventArgs e)
        {

        }

        private void coreBtn_Click(object sender, EventArgs e)
        {

        }

        private void hardcoreBtn_Click(object sender, EventArgs e)
        {

        }

        private void combattrainingBtn_Click(object sender, EventArgs e)
        {

        }

        private void partygamesBtn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #region Modern Warfare 3

        #region Multiplayer Menu
        private void MW3MultiplayerBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.MultiplayerTitle(MW3MultiplayerBox.Text);
        }

        private void MW3PlayOnlineBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.PlayOnline(MW3PlayOnlineBox.Text);
        }

        private void MW3PlayOnlineDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.PlayOnlineDesc(MW3PlayOnlineDescBox.Text);
        }

        private void MW3SplitScreenBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.SplitScreen(MW3SplitScreenBox.Text);
        }

        private void MW3SplitScreenDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.SplitScreenDesc(MW3SplitScreenDescBox.Text);
        }

        private void MW3LanPlayBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.LanParty(MW3LanPlayBox.Text);
        }

        private void MW3LanPlayDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.LanPartyDesc(MW3LanPlayDescBox.Text);
        }

        private void MW3EliteBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.Elite(MW3EliteBox.Text);
        }

        private void MW3EliteDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.EliteDesc(MW3EliteDescBox.Text);
        }

        private void MW3VaultBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.Vault(MW3VaultBox.Text);
        }

        private void MW3VaultDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.VaultDesc(MW3VaultDescBox.Text);
        }

        private void MW3StoreBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.Store(MW3StoreBox.Text);
        }

        private void MW3StoreDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.StoreDesc(MW3StoreDescBox.Text);
        }

        private void MW3OptionsBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.Options(MW3OptionsBox.Text);
        }

        private void MW3OptionsDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.OptionsDesc(MW3OptionsDescBox.Text);
        }

        private void MW3MainMenuBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.MainMenu(MW3MainMenuBox.Text);
        }

        private void MW3MainMenuDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.MuliplayerMenu.MainMenuDesc(MW3MainMenuDescBox.Text);
        }
        #endregion

        #region PublicMatchMenu

        private void MW3FindGameBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.PublicMatch.FindGame(MW3FindGameBox.Text);
        }

        private void MW3FindGameDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.PublicMatch.FindGameDesc(MW3FindGameDescBox.Text);

        }

        private void MW3PrivateMatchBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.PublicMatch.PrivateMatch(MW3PrivateMatchBox.Text);

        }

        private void MW3PrivateMatchDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.PublicMatch.PrivateMatchDesc(MW3PrivateMatchDescBox.Text);

        }

        private void MW3CreateAClassBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.PublicMatch.CreateAClass(MW3CreateAClassBox.Text);

        }

        private void MW3CreateAClassDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.PublicMatch.CreateAClassDesc(MW3CreateAClassDescBox.Text);

        }

        private void MW3CallsignBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.PublicMatch.Callsign(MW3CallsignBox.Text);

        }

        private void MW3CallsignDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.PublicMatch.CallsignDesc(MW3CallsignDescBox.Text);

        }

        private void MW3BarracksBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.PublicMatch.Barracks(MW3BarracksBox.Text);

        }

        private void MW3BarracksDescBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.PublicMatch.BarracksDesc(MW3BarracksDescBox.Text);

        }

        private void MW3AddControllerSplitScreenBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.PublicMatch.AddControllerSplitScreen(MW3AddControllerSplitScreenBox.Text);
        }


        #endregion

        #region Create a Class


        #region PrimaryGuns

        #region Assault Rifles

        private void MW3M4A1Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.AssaultRifles.M4A1(MW3M4A1Box.Text);
        }

        private void MW3M16A4Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.AssaultRifles.M16A4(MW3M16A4Box.Text);

        }

        private void MW3SCARLBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.AssaultRifles.SCARL(MW3SCARLBox.Text);

        }

        private void MW3CM901Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.AssaultRifles.CM901(MW3CM901Box.Text);

        }

        private void MW3TYPE95Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.AssaultRifles.TYPE95(MW3TYPE95Box.Text);

        }

        private void MW3G36CBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.AssaultRifles.G36C(MW3G36CBox.Text);

        }

        private void MW3ACRBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.AssaultRifles.ACR68(MW3ACRBox.Text);

        }

        private void MW3MK14Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.AssaultRifles.MK14(MW3MK14Box.Text);

        }

        private void MW3AK47Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.AssaultRifles.AK47(MW3AK47Box.Text);

        }

        private void MW3FADBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.AssaultRifles.FAD(MW3FADBox.Text);

        }

        private void MW3ASSAULTRIFLESBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.AssaultRifles.AssaultRiflesString(MW3ASSAULTRIFLESBox.Text);

        }

        #endregion

        #region Light Machine Guns
        private void MW3L86LSWBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.LMGs.L86LSW(MW3L86LSWBox.Text);
        }

        private void MW3MG36Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.LMGs.MG36(MW3MG36Box.Text);
        }

        private void MW3PKPPECHENEGBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.LMGs.PKPPECHENEG(MW3PKPPECHENEGBox.Text);
        }

        private void MW3MK46Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.LMGs.MK46(MW3MK46Box.Text);
        }

        private void MW3M60E4Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.LMGs.M60E4(MW3M60E4Box.Text);
        }

        private void MW3LMGsStringBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.LMGs.LMGString(MW3LMGsStringBox.Text);
        }
        #endregion

        #region Sub Machine Guns
        private void MW3MP5Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SMGs.MP5(MW3MP5Box.Text);
        }

        private void MW3UMP45Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SMGs.UMP45(MW3UMP45Box.Text);
        }

        private void MW3PP90M1Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SMGs.PP90M1(MW3PP90M1Box.Text);
        }

        private void MW3P90Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SMGs.P90(MW3P90Box.Text);
        }

        private void MW3PM9Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SMGs.PM9(MW3PM9Box.Text);
        }

        private void MW3MP7Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SMGs.MP7(MW3MP7Box.Text);
        }

        private void MW3SMGsStringBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SMGs.SMGString(MW3SMGsStringBox.Text);
        }


        #endregion

        #region MW3 SniperRifles
        private void MW3Barret50callBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SniperRifles.Barrett50Cal(MW3Barret50callBox.Text);
        }

        private void MW3L118ABtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SniperRifles.L118A(MW3L118ABox.Text);
        }

        private void MW3DragunovBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SniperRifles.Dragunov(MW3DragunovBox.Text);
        }

        private void MW3AS50Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SniperRifles.AS50(MW3AS50Box.Text);
        }

        private void MW3RsassBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SniperRifles.Rsass(MW3RsassBox.Text);
        }

        private void MW3MSRBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SniperRifles.MSR(MW3MSRBox.Text);
        }

        private void MW3SniperRilesBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.SniperRifles.SniperRiflesString(MW3SniperRilesBox.Text);
        }



        #endregion

        #region MW3 Shotguns
        private void MW3USAS12Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.Shotguns.USAS12(MW3USAS12Box.Text);
        }

        private void MW3KSG12Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.Shotguns.KSG12(MW3KSG12Box.Text);
        }

        private void MW3SPAS12Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.Shotguns.SPAS12(MW3SPAS12Box.Text);
        }

        private void MW3AA12Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.Shotguns.AA12(MW3AA12Box.Text);
        }

        private void MW3STRIKERBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.Shotguns.STRIKER(MW3STRIKERBox.Text);
        }

        private void MW3MODEL1887Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.Shotguns.MODEL1887(MW3MODEL1887Box.Text);
        }

        private void MW3ShotGunsBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.Shotguns.ShotGunsString(MW3ShotGunsBox.Text);
        }


        #endregion

        #region MW3 Specials
        private void MW3RiotShieldBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.PrimaryGuns.Specials.RiotShield(MW3RiotShieldBox.Text);
        }

        #endregion
        #endregion

        #region SecondaryGuns

        #region MachinePistols
        private void MW3FMG9Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.SecondaryGuns.MachinePistols.FMG9(MW3FMG9Box.Text);
        }

        private void MW3MP9Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.SecondaryGuns.MachinePistols.MP9(MW3MP9Box.Text);
        }

        private void MW3SkorpionBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.SecondaryGuns.MachinePistols.Skorpion(MW3SkorpionBox.Text);
        }

        private void MW3G18Btn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.SecondaryGuns.MachinePistols.G18(MW3G18Box.Text);
        }

        private void MW3MachinePistolsBtn_Click(object sender, EventArgs e)
        {
            StringChangerV4Fuckit.MW3.CreateAClass.SecondaryGuns.MachinePistols.MachinePistolsString(MW3MachinePistolsBox.Text);
        }

        #endregion

        #region HandGuns

        private void MW3USP45Btn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.HandGuns.USP45(MW3USP45Box.Text);
        }

        private void MW3P99Btn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.HandGuns.P99(MW3P99Box.Text);
        }

        private void MW3MP412Btn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.HandGuns.MP412(MW3MP412Box.Text);
        }

        private void MW344MagnumBtn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.HandGuns.Magnum44(MW344MagnumBox.Text);
        }

        private void MW3FiveSevenBtn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.HandGuns.FiveSeven(MW3FiveSevenBox.Text);
        }

        private void MW3DesertEagleBtn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.HandGuns.Deagle(MW3DesertEagleBox.Text);
        }

        private void MW3HandGunsBtn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.HandGuns.HandgunsString(MW3HandGunsBox.Text);
        }

        #endregion

        #region MW3 Launchers
        private void MW3SMAWBtn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.Launchers.Smaw(MW3SMAWBox.Text);
        }

        private void MW3JavelinBtn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.Launchers.Javelin(MW3JavelinBox.Text);
        }

        private void MW3StingerBtn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.Launchers.Stinger(MW3StingerBox.Text);
        }

        private void MW3XM25Btn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.Launchers.XM25(MW3XM25Box.Text);
        }

        private void MW3M320GLMBtn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.Launchers.M320GLM(MW3M320GLMBox.Text);
        }

        private void MW3RPG7Btn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.Launchers.RPG7(MW3RPG7Box.Text);
        }

        private void MW3LaunchersBtn_Click(object sender, EventArgs e)
        {
            MW3.CreateAClass.SecondaryGuns.Launchers.LauncherString(MW3LaunchersBox.Text);
        }






        #endregion

        #endregion

        #endregion

        #endregion

    }





}

 
