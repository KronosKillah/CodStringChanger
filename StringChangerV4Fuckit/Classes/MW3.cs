   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChangerV4Fuckit
{
    public class MW3
    {
        public class MuliplayerMenu
        {
            //String: MULTIPLAYER
            //Free Mem: 0x500800E0  | Pointer: 0x00CFD45C  | Origional Offset: 0x3190D0A9
            public static void MultiplayerTitle(string textbox)
            {
                FuncDank.ChangeString(0x500800E0, new byte[] { 0x50, 0x08, 0x00, 0xE0 }, textbox, 0x00CFD45C);
            }

            //String: PLAY ONLINE
            //Free Mem: 0x50080150  | Pointer: 0x00CF0844  | Origional Offset: 0x318C9660
            public static void PlayOnline(string textbox)
            {
                FuncDank.ChangeString(0x50080150, new byte[] { 0x50, 0x08, 0x01, 0x50 }, textbox, 0x00CF0844);
            }

            //String: Play online in Call of Duty: Modern Warfare 3 multiplayer.
            //Free Mem: 0x500801C0  | Pointer: 0x00CF0664  | Origional Offset: 0x318C88E5
            public static void PlayOnlineDesc(string textbox)
            {
                FuncDank.ChangeString(0x500801C0, new byte[] { 0x50, 0x08, 0x01, 0xC0 }, textbox, 0x00CF0664);
            }

            //String: SPLIT SCREEN
            //Free Mem: 0x50080230  | Pointer: 0x00CFCFD4  | Origional Offset: 0x3190B54B
            public static void SplitScreen(string textbox)
            {
                FuncDank.ChangeString(0x50080230, new byte[] { 0x50, 0x08, 0x02, 0x30 }, textbox, 0x00CFCFD4);
            }

            //String: Local multiplayer for up to four players.
            //Free Mem: 0x500802A0  | Pointer: 0x00CFCFDC  | Origional Offset: 0x3190B56E
            public static void SplitScreenDesc(string textbox)
            {
                FuncDank.ChangeString(0x500802A0, new byte[] { 0x50, 0x08, 0x02, 0xA0 }, textbox, 0x00CFCFDC);
            }

            //String: LAN PARTY
            //Free Mem: 0x50080310  | Pointer: 0x00CF084C  | Origional Offset: 0x318C8B8D
            public static void LanParty(string textbox)
            {
                FuncDank.ChangeString(0x50080310, new byte[] { 0x50, 0x08, 0x03, 0x10 }, textbox, 0x00CF084C);
            }

            //String: Private matches over a local network
            //Free Mem: 0x50080380  | Pointer: 0x00CF06BC  | Origional Offset: 0x318C8B4D
            public static void LanPartyDesc(string textbox)
            {
                FuncDank.ChangeString(0x50080380, new byte[] { 0x50, 0x08, 0x03, 0x80 }, textbox, 0x00CF06BC);
            }

            //String: ELITE
            //Free Mem: 0x500803F0  | Pointer: 0x00CFD80C  | Origional Offset: 0x3190BBE1
            public static void Elite(string textbox)
            {
                FuncDank.ChangeString(0x500803F0, new byte[] { 0x50, 0x08, 0x03, 0xF0 }, textbox, 0x00CFD80C);
            }

            //String: Download the Call of Duty. Elite application to enhance your multiplayer experience.
            //Free Mem: 0x50080460  | Pointer: 0x00CFD814  | Origional Offset: 0x3190E454
            public static void EliteDesc(string textbox)
            {
                FuncDank.ChangeString(0x50080460, new byte[] { 0x50, 0x08, 0x04, 0x60 }, textbox, 0x00CFD814);
            }

            //String: VAULT
            //Free Mem: 0x50080540  | Pointer: 0x00CFC7D4  | Origional Offset: 0x319088E2
            public static void Vault(string textbox)
            {
                FuncDank.ChangeString(0x50080540, new byte[] { 0x50, 0x08, 0x05, 0x40 }, textbox, 0x00CFC7D4);
            }

            //String: View game replays, screenshots and more.
            //Free Mem: 0x500805B0  | Pointer: 0x00CFC7DC  | Origional Offset: 0x319088F8
            public static void VaultDesc(string textbox)
            {
                FuncDank.ChangeString(0x500805B0, new byte[] { 0x50, 0x08, 0x05, 0xB0 }, textbox, 0x00CFC7DC);
            }

            //String: Store
            //Free Mem: 0x500805B0  | Pointer: 0x?  | Origional Offset: 0x?
            public static void Store(string textbox)
            {
               // FuncDank.ChangeString(0x500805B0, new byte[] { 0x50, 0x08, 0x05, 0xB0 }, textbox, 0x ?);
            }

            //String: Purchase downloadable game content.
            //Free Mem: 0x50080620  | Pointer: 0x00CFDE9C  | Origional Offset: 0x31C6B523
            public static void StoreDesc(string textbox)
            {
                FuncDank.ChangeString(0x50080620, new byte[] { 0x50, 0x08, 0x06, 0x20 }, textbox, 0x00CFDE9C);
            }

            //String: OPTIONS
            //Free Mem: 0x50080690  | Pointer: 0x00CFCFE4  | Origional Offset: 0x3190880D
            public static void Options(string textbox)
            {
                FuncDank.ChangeString(0x50080690, new byte[] { 0x50, 0x08, 0x06, 0x90 }, textbox, 0x00CFCFE4);
            }

            //String: Set game options
            //Free Mem: 0x50080700  | Pointer: 0x00CFCFEC  | Origional Offset: 0x3190B5C0
            public static void OptionsDesc(string textbox)
            {
                FuncDank.ChangeString(0x50080700, new byte[] { 0x50, 0x08, 0x07, 0x00 }, textbox, 0x00CFCFEC);
            }

            //String: MAIN MENU
            //Free Mem: 0x50080770  | Pointer: 0x00CFB4CC  | Origional Offset: 0x319034BE
            public static void MainMenu(string textbox)
            {
                FuncDank.ChangeString(0x50080770, new byte[] { 0x50, 0x08, 0x07, 0x70 }, textbox, 0x00CFB4CC);
            }

            //String: Return to the main menu.
            //Free Mem: 0x500807E0  | Pointer: 0x00CFB4D4  | Origional Offset: 0x319034DC
            public static void MainMenuDesc(string textbox)
            {
                FuncDank.ChangeString(0x500807E0, new byte[] { 0x50, 0x08, 0x07, 0xE0 }, textbox, 0x00CFB4D4);
            }




        }

        public class PublicMatch
        {
            //String: FIND GAME
            //Free Mem: 0x50080850  | Pointer: 0x00CF081C  | Origional Offset: 0x318C959C
            public static void FindGame(string textbox)
            {
                FuncDank.ChangeString(0x50080850, new byte[] { 0x50, 0x08, 0x08, 0x50 }, textbox, 0x00CF081C);
            }

            //String: Pick a game mode and quickly join a game online.
            //Free Mem: 0x500808C0  | Pointer: 0x00CF080C  | Origional Offset: 0x318C9510
            public static void FindGameDesc(string textbox)
            {
                FuncDank.ChangeString(0x500808C0, new byte[] { 0x50, 0x08, 0x08, 0xC0 }, textbox, 0x00CF080C);
            }

            //String: PRIVATE MATCH
            //Free Mem: 0x50080930  | Pointer: 0x00CFCFCC  | Origional Offset: 0x318D6696
            public static void PrivateMatch(string textbox)
            {
                FuncDank.ChangeString(0x50080930, new byte[] { 0x50, 0x08, 0x09, 0x30 }, textbox, 0x00CFCFCC);
            }

            //String: Host a custom game where you can play with your friends.
            //Free Mem: 0x500809A0  | Pointer: 0x00CF2C8C  | Origional Offset: 0x318D639A
            public static void PrivateMatchDesc(string textbox)
            {
                FuncDank.ChangeString(0x500809A0, new byte[] { 0x50, 0x08, 0x09, 0xA0 }, textbox, 0x00CF2C8C);
            }

            //String: CREATE A CLASS
            //Free Mem: 0x50080A10  | Pointer: 0x00CFCF74  | Origional Offset: 0x318D6FEB
            public static void CreateAClass(string textbox)
            {
                FuncDank.ChangeString(0x50080A10, new byte[] { 0x50, 0x08, 0x0A, 0x10 }, textbox, 0x00CFCF74);
            }

            //String: Create your own custom classes.
            //Free Mem: 0x50080A80  | Pointer: 0x00CF2CA4  | Origional Offset: 0x318D647B
            public static void CreateAClassDesc(string textbox)
            {
                FuncDank.ChangeString(0x50080A80, new byte[] { 0x50, 0x08, 0x0A, 0x80 }, textbox, 0x00CF2CA4);
            }

            //String: CALLSIGN
            //Free Mem: 0x50080AF0  | Pointer: 0x00CFCF6C  | Origional Offset: 0x3190B3CB
            public static void Callsign(string textbox)
            {
                FuncDank.ChangeString(0x50080AF0, new byte[] { 0x50, 0x08, 0x0A, 0xF0 }, textbox, 0x00CFCF6C);
            }

            //String: Set your Title, Emblem, and Clan Tag.
            //Free Mem: 0x50080B60  | Pointer: 0x00CFD7B4  | Origional Offset: 0x3190E271
            public static void CallsignDesc(string textbox)
            {
                FuncDank.ChangeString(0x50080B60, new byte[] { 0x50, 0x08, 0x0B, 0x60 }, textbox, 0x00CFD7B4);
            }

            //String: BARRACKS
            //Free Mem: 0x50080BD0  | Pointer: 0x00CFCF7C  | Origional Offset: 0x318D7D77
            public static void Barracks(string textbox)
            {
                FuncDank.ChangeString(0x50080BD0, new byte[] { 0x50, 0x08, 0x0B, 0xD0 }, textbox, 0x00CFCF7C);
            }

            //String: Challenges, Accolades, Prestige, and Leaderboards.
            //Free Mem: 0x50080C40  | Pointer: 0x00CF2CAC  | Origional Offset: 0x318D64B4
            public static void BarracksDesc(string textbox)
            {
                FuncDank.ChangeString(0x50080C40, new byte[] { 0x50, 0x08, 0x0C, 0x40 }, textbox, 0x00CF2CAC);
            }

            //String: Add Controller For Split Screen
            //Free Mem: 0x50080CB0  | Pointer: 0x00CF030C  | Origional Offset: 0x318C7438
            public static void AddControllerSplitScreen(string textbox)
            {
                FuncDank.ChangeString(0x50080CB0, new byte[] { 0x50, 0x08, 0x0C, 0xB0 }, textbox, 0x00CF030C);
            }

            //String: Friends
            //Free Mem: 0x50080D20  | Pointer: 0x00CFC7B4  | Origional Offset: 0x318C7110
            public static void Friends(string textbox)
            {
                FuncDank.ChangeString(0x50080D20, new byte[] { 0x50, 0x08, 0x0D, 0x20 }, textbox, 0x00CFC7B4);
            }

        }

        public class CreateAClass
        {
            public class PrimaryGuns
            {
                public class AssaultRifles
                {
                    //String: Assault Rifles
                    //Free Mem: 0x50080D90  | Pointer: 0x00CFD06C  | Origional Offset: 0x3190B7A7
                    public static void AssaultRiflesString(string textbox)
                    {
                        FuncDank.ChangeString(0x50080D90, new byte[] { 0x50, 0x08, 0x0D, 0x90 }, textbox, 0x00CFD06C);
                    }

                    //String: M4A1
                    //Free Mem: 0x50080E00  | Pointer: 0x00CF5844  | Origional Offset: 0x318E3EFC
                    public static void M4A1(string textbox)
                    {
                        FuncDank.ChangeString(0x50080E00, new byte[] { 0x50, 0x08, 0x0E, 0x00 }, textbox, 0x00CF5844);
                    }

                    //String: M16A4
                    //Free Mem: 0x50080E70  | Pointer: 0x00CF5804  | Origional Offset: 0x318E3E26
                    public static void M16A4(string textbox)
                    {
                        // FuncDank.ChangeString(0x50080E70, new byte[] { 0x50, 0x08, 0x0E, 0x70 }, textbox, 0xx00CF5804);
                    }

                    //String: SCAR-L
                    //Free Mem: 0x50080EE0  | Pointer: 0x00CF5BD4  | Origional Offset: 0x318E4ED5
                    public static void SCARL(string textbox)
                    {
                        FuncDank.ChangeString(0x50080EE0, new byte[] { 0x50, 0x08, 0x0E, 0xE0 }, textbox, 0x00CF5BD4);
                    }

                    //String: CM901
                    //Free Mem: 0x50080F50  | Pointer: 0x00000000  | Origional Offset: 0x318E79EE
                    public static void CM901(string textbox)
                    {
                        FuncDank.ChangeString(0x50080F50, new byte[] { 0x50, 0x08, 0x0F, 0x50 }, textbox, 0x00000000);
                    }

                    //String: TYPE95
                    //Free Mem: 0x50080FC0  | Pointer: 0x00CF6284  | Origional Offset: 0x318E6D2B
                    public static void TYPE95(string textbox)
                    {
                        FuncDank.ChangeString(0x50080FC0, new byte[] { 0x50, 0x08, 0x0F, 0xC0 }, textbox, 0x00CF6284);
                    }

                    //String: G36C
                    //Free Mem: 0x50081030  | Pointer: 0x00CF5814  | Origional Offset: 0x318E3E48
                    public static void G36C(string textbox)
                    {
                        FuncDank.ChangeString(0x50081030, new byte[] { 0x50, 0x08, 0x10, 0x30 }, textbox, 0x00CF5814);
                    }

                    //String: ACR 6.8
                    //Free Mem: 0x500810A0  | Pointer: 0x00CF5FD4  | Origional Offset: 0x318E6187
                    public static void ACR68(string textbox)
                    {
                        FuncDank.ChangeString(0x500810A0, new byte[] { 0x50, 0x08, 0x10, 0xA0 }, textbox, 0x00CF5FD4);
                    }

                    //String: MK14
                    //Free Mem: 0x50081110  | Pointer: 0x00CF5FD4  | Origional Offset: 0x318E671F
                    public static void MK14(string textbox)
                    {
                        FuncDank.ChangeString(0x50081110, new byte[] { 0x50, 0x08, 0x11, 0x10 }, textbox, 0x00CF5FD4);
                    }

                    //String: AK-47
                    //Free Mem: 0x50081180  | Pointer: 0x00CF58B4  | Origional Offset: 0x318E416E
                    public static void AK47(string textbox)
                    {
                        FuncDank.ChangeString(0x50081180, new byte[] { 0x50, 0x08, 0x11, 0x80 }, textbox, 0x00CF58B4);
                    }

                    //String: FAD
                    //Free Mem: 0x500811F0  | Pointer: 0x00CF6344  | Origional Offset: 0x318E704B
                    public static void FAD(string textbox)
                    {
                        FuncDank.ChangeString(0x500811F0, new byte[] { 0x50, 0x08, 0x11, 0xF0 }, textbox, 0x00CF6344);
                    }

                }

                public class SMGs
                {
                    //String: SUB MACHINE GUNS
                    //Free Mem: 0x500817A0  | Pointer: 0x00CFD074  | Origional Offset: 0x3190B7CF
                    public static void SMGString(string textbox)
                    {
                        FuncDank.ChangeString(0x500817A0, new byte[] { 0x50, 0x08, 0x17, 0xA0 }, textbox, 0x00CFD074);
                    }

                    //String: MP5
                    //Free Mem: 0x50081260  | Pointer: 0x00CF5CD4  | Origional Offset: 0x318E3DA2
                    public static void MP5(string textbox)
                    {
                        FuncDank.ChangeString(0x50081260, new byte[] { 0x50, 0x08, 0x12, 0x60 }, textbox, 0x00CF5CD4);
                    }

                    //String: UMP45
                    //Free Mem: 0x500812D0  | Pointer: 0x00CF6574  | Origional Offset: 0x318E7896
                    public static void UMP45(string textbox)
                    {
                        FuncDank.ChangeString(0x500812D0, new byte[] { 0x50, 0x08, 0x12, 0xD0 }, textbox, 0x00CF6574);
                    }

                    //String: PP90M1
                    //Free Mem: 0x50081340  | Pointer: 0x00CF63A4  | Origional Offset: 0x318E71D2
                    public static void PP90M1(string textbox)
                    {
                        FuncDank.ChangeString(0x50081340, new byte[] { 0x50, 0x08, 0x13, 0x40 }, textbox, 0x00CF63A4);
                    }

                    //String: PP90M1
                    //Free Mem: 0x500813B0  | Pointer: 0x00CF57E4  | Origional Offset: 0x318E3DB1
                    public static void P90(string textbox)
                    {
                        FuncDank.ChangeString(0x500813B0, new byte[] { 0x50, 0x08, 0x13, 0xB0 }, textbox, 0x00CF57E4);
                    }

                    //String: PM-9
                    //Free Mem: 0x50081420  | Pointer: 0x00CF602C  | Origional Offset: 0x318E632B
                    public static void PM9(string textbox)
                    {
                        FuncDank.ChangeString(0x50081420, new byte[] { 0x50, 0x08, 0x14, 0x20 }, textbox, 0x00CF602C);
                    }

                    //String: MP7
                    //Free Mem: 0x50081490  | Pointer: 0x00CF60C4  | Origional Offset: 0x318E6584
                    public static void MP7(string textbox)
                    {
                        FuncDank.ChangeString(0x50081490, new byte[] { 0x50, 0x08, 0x14, 0x90 }, textbox, 0x00CF60C4);
                    }


                }

                public class LMGs
                {
                    //String: LIGHT MACHINE GUNS
                    //Free Mem: 0x50081730  | Pointer: 0x00CFD07C  | Origional Offset: 0x3190B7EF
                    public static void LMGString(string textbox)
                    {
                        FuncDank.ChangeString(0x50081730, new byte[] { 0x50, 0x08, 0x17, 0x30 }, textbox, 0x00CFD07C);
                    }

                    //String: L86 LSW
                    //Free Mem: 0x50081500  | Pointer: 0x00CF5684  | Origional Offset: 0x318E37EF
                    public static void L86LSW(string textbox)
                    {
                        FuncDank.ChangeString(0x50081500, new byte[] { 0x50, 0x08, 0x15, 0x00 }, textbox, 0x00CF5684);
                    }

                    //String: MG36
                    //Free Mem: 0x50081570  | Pointer: 0x00CF65CC  | Origional Offset: 0x318E7A02
                    public static void MG36(string textbox)
                    {
                        FuncDank.ChangeString(0x50081570, new byte[] { 0x50, 0x08, 0x15, 0x70 }, textbox, 0x00CF65CC);
                    }

                    //String: PKP PECHENEG
                    //Free Mem: 0x500815E0  | Pointer: 0x00CF562C  | Origional Offset: 0x318E35F8
                    public static void PKPPECHENEG(string textbox)
                    {
                        FuncDank.ChangeString(0x500815E0, new byte[] { 0x50, 0x08, 0x15, 0xE0 }, textbox, 0x00CF562C);
                    }

                    //String: MK46
                    //Free Mem: 0x50081650  | Pointer: 0x00CF55D4  | Origional Offset: 0x318E3483
                    public static void MK46(string textbox)
                    {
                        FuncDank.ChangeString(0x50081650, new byte[] { 0x50, 0x08, 0x16, 0x50 }, textbox, 0x00CF55D4);
                    }

                    //String: M60E4
                    //Free Mem: 0x500816C0  | Pointer: 0x00CF557C  | Origional Offset: 0x318E330E
                    public static void M60E4(string textbox)
                    {
                        FuncDank.ChangeString(0x500816C0, new byte[] { 0x50, 0x08, 0x16, 0xC0 }, textbox, 0x00CF557C);
                    }
                }

                public class SniperRifles
                {
                    //String: Barrett .50CAL
                    //Free Mem: 0x50081810  | Pointer: 0x00CF5824  | Origional Offset: 0x318E3E68
                    public static void Barrett50Cal(string textbox)
                    {
                        FuncDank.ChangeString(0x50081810, new byte[] { 0x50, 0x08, 0x18, 0x10 }, textbox, 0x00CF5824);
                    }

                    //String: L118A
                    //Free Mem: 0x50081880  | Pointer: 0x00CF65DC  | Origional Offset: 0x318E7A32
                    public static void L118A(string textbox)
                    {
                        FuncDank.ChangeString(0x50081880, new byte[] { 0x50, 0x08, 0x18, 0x80 }, textbox, 0x00CF65DC);
                    }

                    //String: Dragunov
                    //Free Mem: 0x500818F0  | Pointer: 0x00CF58D4  | Origional Offset: 0x318E41E1
                    public static void Dragunov(string textbox)
                    {
                        FuncDank.ChangeString(0x500818F0, new byte[] { 0x50, 0x08, 0x18, 0xF0 }, textbox, 0x00CF58D4);
                    }

                    //String: AS50
                    //Free Mem: 0x50081960  | Pointer: 0x00CF6404  | Origional Offset: 0x318E73A1
                    public static void AS50(string textbox)
                    {
                        FuncDank.ChangeString(0x50081960, new byte[] { 0x50, 0x08, 0x19, 0x60 }, textbox, 0x00CF6404);
                    }

                    //String: RSASS
                    //Free Mem: 0x500819D0  | Pointer: 0x00CF61B4  | Origional Offset: 0x318E6970
                    public static void Rsass(string textbox)
                    {
                        FuncDank.ChangeString(0x500819D0, new byte[] { 0x50, 0x08, 0x19, 0xD0 }, textbox, 0x00CF61B4);
                    }

                    //String: MSR
                    //Free Mem: 0x50081A40  | Pointer: 0x00CF6034  | Origional Offset: 0x318E633B
                    public static void MSR(string textbox)
                    {
                        FuncDank.ChangeString(0x50081A40, new byte[] { 0x50, 0x08, 0x1A, 0x40 }, textbox, 0x00CF6034);
                    }

                    //String: SniperRifles
                    //Free Mem: 0x50081AB0  | Pointer: 0x00CF2E24  | Origional Offset: 0x318D6AF4
                    public static void SniperRiflesString(string textbox)
                    {
                        FuncDank.ChangeString(0x50081AB0, new byte[] { 0x50, 0x08, 0x1A, 0xB0 }, textbox, 0x00CF2E24);
                    }


                }

                public class Shotguns
                {
                    //String: USAS 12
                    //Free Mem: 0x50081B90  | Pointer: 0x00CF6094  | Origional Offset: 0x318E64A2
                    public static void USAS12(string textbox)
                    {
                        FuncDank.ChangeString(0x50081B90, new byte[] { 0x50, 0x08, 0x1B, 0x90 }, textbox, 0x00CF6094);
                    }

                    //String: KSG 12
                    //Free Mem: 0x50081C00  | Pointer: 0x00CF6444  | Origional Offset: 0x318E74B3
                    public static void KSG12(string textbox)
                    {
                        FuncDank.ChangeString(0x50081C00, new byte[] { 0x50, 0x08, 0x1C, 0x00 }, textbox, 0x00CF6444);
                    }

                    //String: SPAS-12
                    //Free Mem: 0x50081C70  | Pointer: 0x00CF5ECC  | Origional Offset: 0x318E5C8B
                    public static void SPAS12(string textbox)
                    {
                        FuncDank.ChangeString(0x50081C70, new byte[] { 0x50, 0x08, 0x1C, 0x70 }, textbox, 0x00CF5ECC);
                    }

                    //String: AA-12
                    //Free Mem: 0x50081CE0  | Pointer: 0x00CF5BB4  | Origional Offset: 0x318E4E32
                    public static void AA12(string textbox)
                    {
                        FuncDank.ChangeString(0x50081CE0, new byte[] { 0x50, 0x08, 0x1C, 0xE0 }, textbox, 0x00CF5BB4);
                    }

                    //String: STRIKER
                    //Free Mem: 0x50081D50  | Pointer: 0x00CF5B4C  | Origional Offset: 0x318E4BFD
                    public static void STRIKER(string textbox)
                    {
                        FuncDank.ChangeString(0x50081D50, new byte[] { 0x50, 0x08, 0x1D, 0x50 }, textbox, 0x00CF5B4C);
                    }

                    //String: MODEL 1887
                    //Free Mem: 0x50081DC0  | Pointer: 0x00CF5C64  | Origional Offset: 0x318E5186
                    public static void MODEL1887(string textbox)
                    {
                        FuncDank.ChangeString(0x50081DC0, new byte[] { 0x50, 0x08, 0x1D, 0xC0 }, textbox, 0x00CF5C64);
                    }

                    //String: SHOTGUNS
                    //Free Mem: 0x50081E30  | Pointer: 0x00CF2E1C  | Origional Offset: 0x318D6ADD
                    public static void ShotGunsString(string textbox)
                    {
                        FuncDank.ChangeString(0x50081E30, new byte[] { 0x50, 0x08, 0x1E, 0x30 }, textbox, 0x00CF2E1C);
                    }
                }

                public class Specials
                {
                    //String: RiotShield
                    //Free Mem: 0x50081EA0  | Pointer: 0x00CF348C  | Origional Offset: 0x318D8627
                    public static void RiotShield(string textbox)
                    {
                        FuncDank.ChangeString(0x50081EA0, new byte[] { 0x50, 0x08, 0x1E, 0xA0 }, textbox, 0x00CF348C);
                    }
                }
            }

            public class SecondaryGuns
            {
                public class MachinePistols
                {
                    //String: FMG9
                    //Free Mem: 0x50081F10  | Pointer: 0x00CF64AC  | Origional Offset: 0x318E75E3
                    public static void FMG9(string textbox)
                    {
                        FuncDank.ChangeString(0x50081F10, new byte[] { 0x50, 0x08, 0x1F, 0x10 }, textbox, 0x00CF64AC);
                    }

                    //String: MP9
                    //Free Mem: 0x50081F80  | Pointer: 0x00CF64E4  | Origional Offset: 0x318E76CF
                    public static void MP9(string textbox)
                    {
                        FuncDank.ChangeString(0x50081F80, new byte[] { 0x50, 0x08, 0x1F, 0x80 }, textbox, 0x00CF64E4);
                    }

                    //String: Skorpion
                    //Free Mem: 0x50081FF0  | Pointer: 0x00CF58AC  | Origional Offset: 0x318E4155
                    public static void Skorpion(string textbox)
                    {
                        FuncDank.ChangeString(0x50081FF0, new byte[] { 0x50, 0x08, 0x1F, 0xF0 }, textbox, 0x00CF58AC);
                    }

                    //String: G18
                    //Free Mem: 0x50082060  | Pointer: 0x00CF5BCC  | Origional Offset: 0x318E4155
                    public static void G18(string textbox)
                    {
                        FuncDank.ChangeString(0x50082060, new byte[] { 0x50, 0x08, 0x20, 0x60 }, textbox, 0x00CF5BCC);
                    }

                    //String: Machine Pistols
                    //Free Mem: 0x500820D0  | Pointer: 0x00CF3514  | Origional Offset: 0x318D87D5
                    public static void MachinePistolsString(string textbox)
                    {
                        FuncDank.ChangeString(0x500820D0, new byte[] { 0x50, 0x08, 0x20, 0xD0 }, textbox, 0x00CF3514);
                    }
                }

                public class HandGuns
                {
                    //String: USP .45
                    //Free Mem: 0x50082140  | Pointer: 0x00CF5B1C  | Origional Offset: 0x318E4B00
                    public static void USP45(string textbox)
                    {
                        FuncDank.ChangeString(0x50082140, new byte[] { 0x50, 0x08, 0x21, 0x40 }, textbox, 0x00CF5B1C);
                    }

                    //String: P99
                    //Free Mem: 0x500821B0  | Pointer: 0x00CF604C  | Origional Offset: 0x318E6397
                    public static void P99(string textbox)
                    {
                        FuncDank.ChangeString(0x500821B0, new byte[] { 0x50, 0x08, 0x21, 0xB0 }, textbox, 0x00CF604C);
                    }

                    //String: MP412
                    //Free Mem: 0x50082220  | Pointer: 0x00CF6194  | Origional Offset: 0x318E68F2
                    public static void MP412(string textbox)
                    {
                        FuncDank.ChangeString(0x50082220, new byte[] { 0x50, 0x08, 0x22, 0x20 }, textbox, 0x00CF6194);
                    }

                    //String: .44 Magnum
                    //Free Mem: 0x50082290  | Pointer: 0x00CF6484  | Origional Offset: 0x318E4B57
                    public static void Magnum44(string textbox)
                    {
                        FuncDank.ChangeString(0x50082290, new byte[] { 0x50, 0x08, 0x22, 0x90 }, textbox, 0x00CF6484);
                    }

                    //String: Five Seven
                    //Free Mem: 0x50082290  | Pointer: 0x00CF607C  | Origional Offset: 0x318E6445
                    public static void FiveSeven(string textbox)
                    {
                        FuncDank.ChangeString(0x50082290, new byte[] { 0x50, 0x08, 0x22, 0x90 }, textbox, 0x00CF607C);
                    }

                    //String: Desert Eagle
                    //Free Mem: 0x50082300  | Pointer: 0x00CF58EC  | Origional Offset: 0x318E4220
                    public static void Deagle(string textbox)
                    {
                        FuncDank.ChangeString(0x50082300, new byte[] { 0x50, 0x08, 0x23, 0x00 }, textbox, 0x00CF58EC);
                    }

                    //String: Handguns
                    //Free Mem: 0x50082610  | Pointer: 0x00CF347C  | Origional Offset: 0x318D85F7
                    public static void HandgunsString(string textbox)
                    {
                        FuncDank.ChangeString(0x50082610, new byte[] { 0x50, 0x08, 0x26, 0x10 }, textbox, 0x00CF347C);
                    }
                }

                public class Launchers
                {
                    //String: Smaw
                    //Free Mem: 0x50082370  | Pointer: 0x00CF65E4  | Origional Offset: 0x318E7A45
                    public static void Smaw(string textbox)
                    {
                        FuncDank.ChangeString(0x50082370, new byte[] { 0x50, 0x08, 0x23, 0x70 }, textbox, 0x00CF65E4);
                    }

                    //String: Javelin
                    //Free Mem: 0x500823E0  | Pointer: 0x00CF5914  | Origional Offset: 0x318E4285
                    public static void Javelin(string textbox)
                    {
                        FuncDank.ChangeString(0x500823E0, new byte[] { 0x50, 0x08, 0x23, 0xE0 }, textbox, 0x00CF5914);
                    }

                    //String: Stinger
                    //Free Mem: 0x50082450  | Pointer: 0x00CF591C  | Origional Offset: 0x318E429C
                    public static void Stinger(string textbox)
                    {
                        FuncDank.ChangeString(0x50082450, new byte[] { 0x50, 0x08, 0x24, 0x50 }, textbox, 0x00CF591C);
                    }

                    //String: XM25
                    //Free Mem: 0x500824C0  | Pointer: 0x00CF5FAC  | Origional Offset: 0x318E60DE
                    public static void XM25(string textbox)
                    {
                        FuncDank.ChangeString(0x500824C0, new byte[] { 0x50, 0x08, 0x24, 0xC0 }, textbox, 0x00CF5FAC);
                    }

                    //String: M320 GLM
                    //Free Mem: 0x50082530  | Pointer: 0x00CF6124  | Origional Offset: 0x318E670A
                    public static void M320GLM(string textbox)
                    {
                        FuncDank.ChangeString(0x50082530, new byte[] { 0x50, 0x08, 0x25, 0x30 }, textbox, 0x00CF6124);
                    }

                    //String: RPG-7
                    //Free Mem: 0x500825A0  | Pointer: 0x00CF57BC  | Origional Offset: 0x318E3D47
                    public static void RPG7(string textbox)
                    {
                        FuncDank.ChangeString(0x500825A0, new byte[] { 0x50, 0x08, 0x25, 0xA0 }, textbox, 0x00CF57BC);
                    }

                    //String: Launchers
                    //Free Mem: 0x50082680  | Pointer: 0x00CF3334  | Origional Offset: 0x318D805E
                    public static void LauncherString(string textbox)
                    {
                        FuncDank.ChangeString(0x50082680, new byte[] { 0x50, 0x08, 0x26, 0x80 }, textbox, 0x00CF3334);
                    }
                }
            }

            public class Lethals
            {
                //String: LETHAL
                //Free Mem: 0x500826F0  | Pointer: 0x00CFD17C  | Origional Offset: 0x318F69F6
                public static void LethalString(string textbox)
                {
                    FuncDank.ChangeString(0x500826F0, new byte[] { 0x50, 0x08, 0x26, 0xF0 }, textbox, 0x00CFD17C);
                }

                //String: Semtex
                //Free Mem: 0x50082760  | Pointer: 0x00CF74FC  | Origional Offset: 0x318EC996
                public static void Semtex(string textbox)
                {
                    FuncDank.ChangeString(0x50082760, new byte[] { 0x50, 0x08, 0x27, 0x60 }, textbox, 0x00CF74FC);
                }

                //String: Throwing Knife
                //Free Mem: 0x500827D0  | Pointer: 0x00CF750C  | Origional Offset: 0x318E3D08
                public static void ThrowingKnife(string textbox)
                {
                    FuncDank.ChangeString(0x500827D0, new byte[] { 0x50, 0x08, 0x27, 0xD0 }, textbox, 0x00CF750C);
                }

                //String: Bouncing Betty
                //Free Mem: 0x50082840  | Pointer: 0x00CF7764  | Origional Offset: 0x318ED65E
                public static void BouncingBetty(string textbox)
                {
                    FuncDank.ChangeString(0x50082840, new byte[] { 0x50, 0x08, 0x28, 0x40 }, textbox, 0x00CF7764);
                }


            }
        }

    }
}
