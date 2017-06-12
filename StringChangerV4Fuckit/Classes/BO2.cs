using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace StringChangerV4Fuckit
{
    public class BO2
    {
        public class MuliplayerMenu
        {

            //String: PLAY ONLINE
            //Free Mem: 0x51000770 | Pointer: 0x01346A74 | Origional Offset: 0x308EA06D
            public static void PlayOnline(string textbox)
            {
                FuncDank.ChangeString(0x51000770, new byte[] { 0x51, 0x00, 0x07, 0x70 }, textbox, 0x01346A74);
            }


            //String: LAN PARTY
            //Free Mem: 0x510007E0 | Pointer: 0x013469BC | Origional Offset: 0x308E9A1C
            public static void LanParty(string textbox)
            {
                FuncDank.ChangeString(0x510007E0, new byte[] { 0x51, 0x00, 0x07, 0xE0 }, textbox, 0x013469BC);
            }


            //String: LOCAL
            //Free Mem: 0x51000850 | Pointer: 0x01353574 | Origional Offset: 0x3093034F 
            public static void Local(string textbox)
            {
                FuncDank.ChangeString(0x51000850, new byte[] { 0x51, 0x00, 0x08, 0x50 }, textbox, 0x01353574);
            }


            //String: MULTIPLAYER
            //Free Mem: 0x51000000 | Pointer: 0x0135133C | Origional Offset: 0x309258EF
            public static void Muliplayer(string textbox)
            {
                FuncDank.ChangeString(0x51000000, new byte[] { 0x51, 0x00, 0x00, 0x00 }, textbox, 0x0135133C);
            }


            //String: PUBLIC MATCH
            //Free Mem: 0x51000070 | Pointer: 0x01354FFC | Origional Offset: 0x3090FE68
            public static void PublicMatch(string textbox)
            {
                FuncDank.ChangeString(0x51000070, new byte[] { 0x51, 0x00, 0x00, 0x70 }, textbox, 0x01354FFC);
            }


            //String: Play online to earn Experience (XP) and rewards. 
            //Free Mem: 0x510000E0 | Pointer: 0x0134314C | Origional Offset: 0x30166517
            public static void PublicMatchDesc(string textbox)
            {
                FuncDank.ChangeString(0x510000E0, new byte[] { 0x51, 0x00, 0x00, 0xE0 }, textbox, 0x0134314C);
            }


            //String: LEAGUE PLAY
            //Free Mem: 0x51000150 | Pointer: 0x0135527C | Origional Offset: 0x3093A88E
            public static void LeaguePLay(string textbox)
            {
                FuncDank.ChangeString(0x51000150, new byte[] { 0x51, 0x00, 0x01, 0x50 }, textbox, 0x0135527C);
            }


            //String: Find opponents at your skill level and battle for top position in League Ladders
            //Free Mem: 0x510001C0 | Pointer: 0x0134313C | Origional Offset: 0x30166451
            public static void LeaguePLayDesc(string textbox)
            {
                FuncDank.ChangeString(0x510001C0, new byte[] { 0x51, 0x00, 0x01, 0xC0 }, textbox, 0x0134313C);
            }


            //String: CUSTOM GAMES
            //Free Mem: 0x51000230 | Pointer: 0x0135673C | Origional Offset: 0x309258EF 
            public static void CustomGame(string textbox)
            {
                FuncDank.ChangeString(0x51000230, new byte[] { 0x51, 0x00, 0x02, 0x30 }, textbox, 0x0135673C);
            }


            //String: Create a match to play with your friends. Save and share your own custom game rules.
            //Free Mem: 0x510002A0 | Pointer: 0x0134E2EC | Origional Offset: 0x30916B10 
            public static void CustomGameDesc(string textbox)
            {
                FuncDank.ChangeString(0x510002A0, new byte[] { 0x51, 0x00, 0x02, 0xA0 }, textbox, 0x0134E2EC);
            }


            //String: THEATER
            //Free Mem: 0x51000310 | Pointer: 0x01354FF4 | Origional Offset: 0x30915CEA 
            public static void Theater(string textbox)
            {
                FuncDank.ChangeString(0x51000310, new byte[] { 0x51, 0x00, 0x03, 0x10 }, textbox, 0x01354FF4);
            }


            //String: Watch Films with your friends, and create Clips to share with the community.
            //Free Mem: 0x51000380 | Pointer: 0x013505C4 | Origional Offset: 0x30915CEA new byte[] { 0x51, 0x00, 0x03, 0x80 }
            public static void TheaterDesc(string textbox)
            {
                FuncDank.ChangeString(0x51000380, new byte[] { 0x51, 0x00, 0x03, 0x80 }, textbox, 0x013505C4);
            }


            //String: COD TV
            //Free Mem: 0x510003F0 | Pointer: 0x01341EDC | Origional Offset: 0x3015B849 
            public static void CodTv(string textbox)
            {
                FuncDank.ChangeString(0x510003F0, new byte[] { 0x51, 0x00, 0x03, 0xF0 }, textbox, 0x01341EDC);
            }


            //String: Browse official Call of Duty videos and the best content from the community. 
            //Free Mem: 0x51000460 | Pointer: 0x01343144  | Origional Offset: 0x301664B9
            public static void CodTvDesc(string textbox)
            {
                FuncDank.ChangeString(0x51000460, new byte[] { 0x51, 0x00, 0x04, 0x60 }, textbox, 0x01343144);
            }


            //String: BARRACKS
            //Free Mem: 0x510004D0 | Pointer: 0x013551A4  | Origional Offset: 0x30913686
            public static void Barracks(string textbox)
            {
                FuncDank.ChangeString(0x510004D0, new byte[] { 0x51, 0x00, 0x04, 0xD0 }, textbox, 0x013551A4);
            }


            //String: Edit your Playercard, browse Challenges, view your Combat Record and more.
            //Free Mem: 0x51000540 | Pointer: 0x01342E1C  | Origional Offset: 0x3015E052
            public static void BarracksDesc(string textbox)
            {
                FuncDank.ChangeString(0x51000540, new byte[] { 0x51, 0x00, 0x05, 0x40 }, textbox, 0x01342E1C);
            }


            //String: OPTIONS
            //Free Mem: 0x510005B0 | Pointer: 0x0135134C  | Origional Offset: 0x3092591B
            public static void Options(string textbox)
            {
                FuncDank.ChangeString(0x510005B0, new byte[] { 0x51, 0x00, 0x05, 0xb0 }, textbox, 0x0135134C);
            }


            //String: Edit your game, audio and display settings.
            //Free Mem: 0x51000620 | Pointer: 0x013505CC  | Origional Offset: 0x30921A54
            public static void OptionsDesc(string textbox)
            {
                FuncDank.ChangeString(0x51000620, new byte[] { 0x51, 0x00, 0x06, 0x20 }, textbox, 0x013505CC);
            }


            //String: STORE
            //Free Mem: 0x51000690 | Pointer: 0x01354D9C  | Origional Offset: 30931F89
            public static void Store(string textbox)
            {
                FuncDank.ChangeString(0x51000690, new byte[] { 0x51, 0x00, 0x06, 0x90 }, textbox, 0x01354D9C);
            }


            //String: Browse the Store for avatars, themes, downloadable content and more.
            //Free Mem: 0x51000700 | Pointer: 0x01341A94  | Origional Offset: 0x30931F89
            public static void StoreDesc(string textbox)
            {
                FuncDank.ChangeString(0x51000700, new byte[] { 0x51, 0x00, 0x07, 0x00 }, textbox, 0x01341A94);
            }

        }

        public class MuliplayerMenuMisc
        {

            //String: Add Controller For Split Screen
            //Free Mem: 0x510008C0 | Pointer: 0x01346ECC  | Origional Offset: 0x30931F89
            public static void ControllerSplitSCreen(string textbox)
            {
                FuncDank.ChangeString(0x510008C0, new byte[] { 0x51, 0x00, 0x08, 0xC0 }, textbox, 0x01346ECC);
            }


            //String: PLayers Online
            //Free Mem: 0x51000930 | Pointer: 0x013563EC  | Origional Offset: 0x3094116E
            public static void PlayersOnline(string textbox)
            {
                FuncDank.ChangeString(0x51000930, new byte[] { 0x51, 0x00, 0x09, 0x30 }, "&&1 " + textbox, 0x013563EC);
            }


            //String: Back
            //Free Mem: 0x510009A0 | Pointer: 0x013513CC  | Origional Offset: 0x308DC3B2
            public static void BackButton(string textbox)
            {
                FuncDank.ChangeString(0x510009A0, new byte[] { 0x51, 0x00, 0x09, 0xA0 }, textbox, 0x013513CC);
            }


            //String: Friends Playing Black Ops II
            //Free Mem: 0x51000A10 | Pointer: 0x013421B4  | Origional Offset: 0x3015CF84
            public static void FriendsPlaying(string textbox)
            {
                FuncDank.ChangeString(0x51000A10, new byte[] { 0x51, 0x00, 0x0A, 0x10 }, textbox, 0x013421B4);
            }

        }

        public class PublicMatch
        {
            //String: Find Match
            //Free Mem: 0x51000a80 | Pointer: 0x0134F85C  | Origional Offset: 0x3091D504
            public static void FindMatch(string textbox)
            {
                FuncDank.ChangeString(0x51000a80, new byte[] { 0x51, 0x00, 0x0a, 0x80 }, textbox, 0x0134F85C);
            }
            //String: Pick a game mode and join a match online.
            //Free Mem: 0x51000af0 | Pointer: 0x0134F194  | Origional Offset: 0x3091B06A
            public static void FindMatchDesc(string textbox)
            {
                FuncDank.ChangeString(0x51000af0, new byte[] { 0x51, 0x00, 0x0a, 0xf0 }, textbox, 0x0134F194);
            }

            //String: Create A Class
            //Free Mem: 0x51000b60 | Pointer: 0x013552AC  | Origional Offset: 0x30904F62
            public static void CreateAClass(string textbox)
            {
                FuncDank.ChangeString(0x51000b60, new byte[] { 0x51, 0x00, 0x0b, 0x60 }, textbox, 0x013552AC);
            }

            //String: Customize your loadout.
            //Free Mem: 0x51000bd0 | Pointer: 0x0134ABFC  | Origional Offset: 0x30904F8D
            public static void CreateAClassDesc(string textbox)
            {
                FuncDank.ChangeString(0x51000bd0, new byte[] { 0x51, 0x00, 0x0b, 0xd0 }, textbox, 0x0134ABFC);
            }

            //String: SCORESTREAKS
            //Free Mem: 0x51000c40 | Pointer: 0x013555DC  | Origional Offset: 0x309051C7
            public static void ScoreStreaks(string textbox)
            {
                FuncDank.ChangeString(0x51000c40, new byte[] { 0x51, 0x00, 0x0c, 0x40 }, textbox, 0x013555DC);
            }

            //String: Customize your Scorestreak rewards.
            //Free Mem: 0x51000cb0 | Pointer: ?  | Origional Offset: 0x309051ED
            public static void ScoreStreaksDesc(string textbox)
            {
                //FuncDank.ChangeString(0x51000cb0, new byte[] { 0x51, 0x00, 0x0c, 0xb0 }, textbox, 0x013555DC);
            }

            //String: LIVESTREAM
            //Free Mem: 0x51000d20 | Pointer: 0x0134206C  | Origional Offset: 0x3015C5C5
            public static void LiveStream(string textbox)
            {
                FuncDank.ChangeString(0x51000d20, new byte[] { 0x51, 0x00, 0x0d, 0x20 }, textbox, 0x0134206C);
            }

            //String: Stream your game live to the internet.
            //Free Mem: 0x51000d90 | Pointer: 0x0134204C  | Origional Offset: 0x3015C4F4
            public static void LiveStreamDesc(string textbox)
            {
                FuncDank.ChangeString(0x51000d90, new byte[] { 0x51, 0x00, 0x0d, 0x90 }, textbox, 0x0134204C);
            }

        }

        public class CreateAClass
        {
            public class Perks
            {

                //String: Lightweight
                //Free Mem: 0x51000e00 | Pointer: 0x0134B1F4  | Origional Offset: 0x30906bbe
                public static void LightWeight(string textbox)
                {
                    FuncDank.ChangeString(0x51000e00, new byte[] { 0x51, 0x00, 0x0e, 0x00 }, textbox, 0x0134B1F4);
                }

                //String: Move faster. Take no damamge when falling
                //Free Mem: 0x51000e70 | Pointer: 0x0134B1FC  | Origional Offset: 0x30906bdc
                public static void LightWeightDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51000e70, new byte[] { 0x51, 0x00, 0x0e, 0x70 }, textbox, 0x0134B1FC);
                }

                //String: Hardline
                //Free Mem: 0x51000EE0 | Pointer: 0x0134B1B4  | Origional Offset: 0x30906a99
                public static void Hardline(string textbox)
                {
                    FuncDank.ChangeString(0x51000EE0, new byte[] { 0x51, 0x00, 0x0e, 0xe0 }, textbox, 0x0134B1B4);
                }

                //String: Earn Scorestreaks Faster
                //Free Mem: 0x51000F50 | Pointer: 0x0134B1BC  | Origional Offset: 0x30906ab1
                public static void HardlineDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51000F50, new byte[] { 0x51, 0x00, 0x0f, 0x50 }, textbox, 0x0134B1BC);
                }

                //String: Blind Eye
                //Free Mem: 0x51000FC0 | Pointer: 0x0134B114  | Origional Offset: 0x30906610
                public static void BlindEye(string textbox)
                {
                    FuncDank.ChangeString(0x51000FC0, new byte[] { 0x51, 0x00, 0x0f, 0xc0 }, textbox, 0x0134B114);
                }

                //String: Undetectable by AI controlled air support
                //Free Mem: 0x51001030 | Pointer: 0x0134B11C  | Origional Offset: 0x3090662a
                public static void BlindEyeDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51001030, new byte[] { 0x51, 0x00, 0x10, 0x30 }, textbox, 0x0134B11C);
                }

                //String: Flak Jacket
                //Free Mem: 0x510010A0 | Pointer: 0x0134B184 | Origional Offset: 0x30906928
                public static void FlakJacket(string textbox)
                {
                    FuncDank.ChangeString(0x510010A0, new byte[] { 0x51, 0x00, 0x10, 0xA0 }, textbox, 0x0134B184);
                }

                //String: Take less Explosive damage
                //Free Mem: 0x51001110 | Pointer: 0x0134B18C  | Origional Offset: 0x30906946
                public static void FlackJacketDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51001110, new byte[] { 0x51, 0x00, 0x11, 0x10 }, textbox, 0x0134B18C);
                }

                //String: Ghost
                //Free Mem: 0x51001180 | Pointer: 0x0134B19C  | Origional Offset: 0x30906979
                public static void Ghost(string textbox)
                {
                    FuncDank.ChangeString(0x51001180, new byte[] { 0x51, 0x00, 0x11, 0x80 }, textbox, 0x0134B19C);
                }

                //String: Cannot be detected by enemy UAV's while moving, planting or defusing bombs, or while controlling score streaks.
                //Free Mem: 0x510011F0 | Pointer: 0x0134B19C  | Origional Offset: 0x3090698B
                public static void GhostDesc(string textbox)
                {
                    FuncDank.ChangeString(0x510011F0, new byte[] { 0x51, 0x00, 0x11, 0xf0 }, textbox, 0x0134B41C);
                }

                //String: Toughness
                //Free Mem: 0x51001260 | Pointer: 0x0134B324  | Origional Offset: 0x30907280
                public static void Toughness(string textbox)
                {
                    FuncDank.ChangeString(0x51001260, new byte[] { 0x51, 0x00, 0x12, 0x60 }, textbox, 0x0134B324);
                }

                //String: Flitch Less when shot
                //Free Mem: 0x510012D0 | Pointer: 0x0134B32C  | Origional Offset: 0x3090729a
                public static void ToughnessDesc(string textbox)
                {
                    FuncDank.ChangeString(0x510012D0, new byte[] { 0x51, 0x00, 0x12, 0xD0 }, textbox, 0x0134B32C);
                }

                //String: Cold Blooded
                //Free Mem: 0x51001340 | Pointer: 0x0134B134  | Origional Offset: 0x309066cd
                public static void ColdBlooded(string textbox)
                {
                    FuncDank.ChangeString(0x51001340, new byte[] { 0x51, 0x00, 0x13, 0x40 }, textbox, 0x0134B134);
                }

                //String: Resistant to targeting Systems Etc
                //Free Mem: 0x510013B0 | Pointer: 0x0134B13C  | Origional Offset: 0x309066ED
                public static void ColdBloodedDesc(string textbox)
                {
                    FuncDank.ChangeString(0x510013B0, new byte[] { 0x51, 0x00, 0x13, 0xb0 }, textbox, 0x0134B13C);
                }

                //String: Fast Hands
                //Free Mem: 0x51001420 | Pointer: 0x0134B41C  | Origional Offset: 0x309076AF
                public static void FastHands(string textbox)
                {
                    FuncDank.ChangeString(0x51001420, new byte[] { 0x51, 0x00, 0x14, 0x20 }, textbox, 0x0134B41C);
                }

                //String: Swap Weapons faster and use equipment faster
                //Free Mem: 0x51001490 | Pointer: 0x0134B424  | Origional Offset: 0x309076cb
                public static void FastHandsDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51001490, new byte[] { 0x51, 0x00, 0x14, 0x90 }, textbox, 0x0134B424);
                }

                //String: Hard Wired
                //Free Mem: 0x51001560 | Pointer: 0x0134B42C  | Origional Offset: 0x30907741 
                public static void HardWired(string textbox)
                {
                    FuncDank.ChangeString(0x51001560, new byte[] { 0x51, 0x00, 0x15, 0x60 }, textbox, 0x0134B42C);
                }

                //String: Immune to Counter-UAV and EMP.
                //Free Mem: 0x51001630 | Pointer: 0x0134B434  | Origional Offset: 0x3090775D
                public static void HardWiredDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51001630, new byte[] { 0x51, 0x00, 0x16, 0x30 }, textbox, 0x0134B434);
                }

                //String: Scavenger
                //Free Mem: 0x51001700 | Pointer: 0x0134B284  | Origional Offset: 0x30906F06
                public static void Scavenger(string textbox)
                {
                    FuncDank.ChangeString(0x51001700, new byte[] { 0x51, 0x00, 0x17, 0x00 }, textbox, 0x0134B284);
                }

                //String: Replenish ammo and equipment from enemies killed by non-explosive weapons.
                //Free Mem: 0x51001770 | Pointer: 0x0134B28C  | Origional Offset: 0x30906F20
                public static void ScavengerDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51001770, new byte[] { 0x51, 0x00, 0x17, 0x70 }, textbox, 0x0134B28C);
                }

                //String: Dexterity
                //Free Mem: 0x51001840 | Pointer: 0x0134B0C4  | Origional Offset: 0x30906473
                public static void Dexterity(string textbox)
                {
                    FuncDank.ChangeString(0x51001840, new byte[] { 0x51, 0x00, 0x18, 0x40 }, textbox, 0x0134B0C4);

                }

                //String: Aim faster after sprinting. Mantle and climb faster. 
                //Free Mem: 0x51001910 | Pointer: 0x0134B0CC  | Origional Offset: 0x3090648D
                public static void DexterityDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51001910, new byte[] { 0x51, 0x00, 0x19, 0x10 }, textbox, 0x0134B0CC);
                }

                //String: Extreme Conditioning
                //Free Mem: 0x51002050 | Pointer: 0x0134B154  | Origional Offset: 0x30906813
                public static void ExtremeConditioning(string textbox)
                {
                    FuncDank.ChangeString(0x51002050, new byte[] { 0x51, 0x00, 0x20, 0x50 }, textbox, 0x0134B154);
                }

                //String: Sprint for a longer duration
                //Free Mem: 0x51002120 | Pointer: 0x0134B15C 0x0134B494 | Origional Offset: 0x30906843
                public static void ExtremeConditioningDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002120, new byte[] { 0x51, 0x00, 0x21, 0x20 }, textbox, 0x0134B15C); //////////////////////////////////////////////////////////////////////////////
                }
                //String: Engineer
                //Free Mem: 0x51002190 | Pointer: 0x0134B1A4  | Origional Offset: 0x30906A0C
                public static void Engineer(string textbox)
                {
                    FuncDank.ChangeString(0x51002190, new byte[] { 0x51, 0x00, 0x21, 0x90 }, textbox, 0x0134B1A4);
                }

                //String: Show enemy equipment in the world.  Delay triggered explosives. Reroll and booby trap Care Packages.
                //Free Mem: 0x51002260 | Pointer: 0x0134B1AC  | Origional Offset: 0x30906A22
                public static void EngineerDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002260, new byte[] { 0x51, 0x00, 0x22, 0x60 }, textbox, 0x0134B1AC);
                }

                //String: Tactical Mask
                //Free Mem: 0x51002330 | Pointer: 0x0134B2F4  | Origional Offset: 0x30907170
                public static void TacticalMask(string textbox)
                {
                    FuncDank.ChangeString(0x51002330, new byte[] { 0x51, 0x00, 0x23, 0x30 }, textbox, 0x0134B2F4);
                }

                //String: Reduce the effects of Flashbangs, Concussion Grenades, and Shock Charges.
                //Free Mem: 0x51002400 | Pointer: 0x0134B2FC 0x0134B30C  | Origional Offset: 0x30907192
                public static void TacticalMaskDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002400, new byte[] { 0x51, 0x00, 0x24, 0x00 }, textbox, 0x0134B2FC);
                }

                //String: Dead Silence
                //Free Mem: 0x51002470 | Pointer: 0x0134B224  | Origional Offset: 0x30906CC6
                public static void DeadSilence(string textbox)
                {
                    FuncDank.ChangeString(0x51002470, new byte[] { 0x51, 0x00, 0x24, 0x70 }, textbox, 0x0134B224);
                }

                //String: Move Silently
                //Free Mem: 0x51002540 | Pointer: 0x0134B22C  | Origional Offset: 0x30906CDF
                public static void DeadSilenceDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002540, new byte[] { 0x51, 0x00, 0x25, 0x40 }, textbox, 0x0134B22C);
                }

                //String: Awareness 
                //Free Mem: 0x51002610 | Pointer: 0x0134B0F4 | Origional Offset: 0x30906577
                public static void Awareness(string textbox)
                {
                    FuncDank.ChangeString(0x51002610, new byte[] { 0x51, 0x00, 0x26, 0x10 }, textbox, 0x0134B0F4);
                }

                //String: Enemy movements are easier to hear.
                //Free Mem: 0x51002680 | Pointer: 0x0x0134B41C  | Origional Offset: 0x30906591
                public static void AwarenessDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002680, new byte[] { 0x51, 0x00, 0x26, 0x80 }, textbox, 0x0134B41C);
                }
            }

            public class LethalsTacticals
            {
                //String: Grenade
                //Free Mem:0x 51002760  | Pointer: 0x013476A4  | Origional Offset: 0x308f0957
                public static void Grenade(string textbox)
                {
                    FuncDank.ChangeString(0x51002760, new byte[] { 0x51, 0x00, 0x27, 0x60 }, textbox, 0x013476A4);
                }

                //String: Produces lethal radius damage upon detonation.
                //Free Mem:0x 510027D0 | Pointer: 0x013476AC  | Origional Offset: 0x308F0972
                public static void GrenadeDesc(string textbox)
                {
                    FuncDank.ChangeString(0x510027D0, new byte[] { 0x51, 0x00, 0x27, 0xD0 }, textbox, 0x013476AC);
                }

                //String: Semtex
                //Free Mem:0x 51002840  | Pointer: 0x01347AEC  | Origional Offset: 0x308F1F55
                public static void Semtex(string textbox)
                {
                    FuncDank.ChangeString(0x51002840, new byte[] { 0x51, 0x00, 0x28, 0x40 }, textbox, 0x01347AEC);
                }

                //String: Grenade that sticks to surfaces before detonating.
                //Free Mem:0x 510028B0  | Pointer: 0x01347AF4  | Origional Offset: 0x308F1F72
                public static void SemtexDesc(string textbox)
                {
                    FuncDank.ChangeString(0x510028B0, new byte[] { 0x51, 0x00, 0x28, 0xB0 }, textbox, 0x01347AF4);

                }

                //String: Combat Axe
                //Free Mem:0x 51002920  | Pointer: 0x01347754  | Origional Offset: 0x308F0CA7
                public static void CombatAxe(string textbox)
                {
                    FuncDank.ChangeString(0x51002920, new byte[] { 0x51, 0x00, 0x29, 0x20 }, textbox, 0x01347754);

                }

                //String: Retrievable axe that causes instant death on impact.
                //Free Mem:0x 51002990 | Pointer: 0x0134775C  | Origional Offset: 0x308F0CC1
                public static void CombatAxeDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002990, new byte[] { 0x51, 0x00, 0x29, 0x90 }, textbox, 0x0134775C);

                }

                //String: Bouncing Betty
                //Free Mem:0x 51002A00 | Pointer: 0x013476B4  | Origional Offset: 0x308F09B9
                public static void Bouncingbetty(string textbox)
                {
                    FuncDank.ChangeString(0x51002A00, new byte[] { 0x51, 0x00, 0x2A, 0x00 }, textbox, 0x013476B4);

                }

                //String: Proximity mine that launches into the air before detonating.  Can be avoided by crouching or going prone.
                //Free Mem:0x 51002A70  | Pointer: 0x01348F5C  | Origional Offset: 0x308F8B5B
                public static void BouncingbettyDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002A70, new byte[] { 0x51, 0x00, 0x2A, 0x70 }, textbox, 0x01348F5C);

                }

                //String: C4
                //Free Mem:0x 51002AE0  | Pointer: 0x  | Origional Offset: 0x3
                public static void C4(string textbox)
                {
                    FuncDank.ChangeString(0x51002AE0, new byte[] { 0x51, 0x00, 0x2A, 0xE0 }, textbox, 0x013476A4);

                }

                //String: A plastic explosive device that is detonated remotely by double-tapping ^BBUTTON_INTERACT^.
                //Free Mem:0x 51002B50  | Pointer: 0x0134707C  | Origional Offset: 0x308ED427
                public static void C4Desc(string textbox)
                {
                    FuncDank.ChangeString(0x51002B50, new byte[] { 0x51, 0x00, 0x2B, 0x50 }, textbox, 0x0134707C);

                }

                //String: Claymore
                //Free Mem:0x 51002BC0  | Pointer: 0x013475FC  | Origional Offset: 0x308F055D
                public static void Claymore(string textbox)
                {
                    FuncDank.ChangeString(0x51002BC0, new byte[] { 0x51, 0x00, 0x2B, 0xC0 }, textbox, 0x013475FC);

                }

                //String: Directional anti-personnel mine that triggers a proximity-based explosion.
                //Free Mem:0x 51002C30  | Pointer: 0x01347604  | Origional Offset: 0x308F0576
                public static void ClaymoreDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002C30, new byte[] { 0x51, 0x00, 0x2C, 0x30 }, textbox, 0x01347604);

                }

                //String: Concusstion
                //Free Mem:0x 51002CA0  | Pointer: 0x01347AFC  | Origional Offset: 0x308F1FC0
                public static void Concussion(string textbox)
                {
                    FuncDank.ChangeString(0x51002CA0, new byte[] { 0x51, 0x00, 0x2C, 0xA0 }, textbox, 0x01347AFC);

                }

                //String:Disorients enemies and slows movement.
                //Free Mem:0x 51002D10  | Pointer: 0x01347B04  | Origional Offset: 0x308F1FDF
                public static void ConcussionDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002D10, new byte[] { 0x51, 0x00, 0x2D, 0x10 }, textbox, 0x01347B04);

                }

                //String: Smoke Grenade
                //Free Mem:0x 51002D80  | Pointer: 0x01347BC4  | Origional Offset: 0x308F1E58
                public static void StunGrenade(string textbox)
                {
                    FuncDank.ChangeString(0x51002D80, new byte[] { 0x51, 0x00, 0x2D, 0x80 }, textbox, 0x01347BC4);

                }

                //String: Produces a smoke screen immediately upon impact.
                //Free Mem:0x 51002DF0  | Pointer: 0x01347BCC  | Origional Offset: 0x308F23EC
                public static void StungrGenadeDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002DF0, new byte[] { 0x51, 0x00, 0x2D, 0xF0 }, textbox, 0x01347BCC);

                }

                //String: Sensor Grenade
                //Free Mem:0x 51002E60  | Pointer: 0x01348F7C  | Origional Offset: 0x308F8C94
                public static void SensorGrenade(string textbox)
                {
                    FuncDank.ChangeString(0x51002E60, new byte[] { 0x51, 0x00, 0x2E, 0x60 }, textbox, 0x01348F7C);

                }

                //String: Detects enemy soldiers within line of sight.
                //Free Mem:0x 51002ED0  | Pointer: 0x01348F84  | Origional Offset: 0x308F8CB9
                public static void SensorGrenadeDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002ED0, new byte[] { 0x51, 0x00, 0x2E, 0xD0 }, textbox, 0x01348F84);

                }

                //String: EMP Grenade
                //Free Mem:0x 51002F40  | Pointer: 0x01347EAC  | Origional Offset: 0x308F3516
                public static void EmpGrenade(string textbox)
                {
                    FuncDank.ChangeString(0x51002F40, new byte[] { 0x51, 0x00, 0x2F, 0x40 }, textbox, 0x01347EAC);

                }

                //String: Disables nearby enemy electronic systems .
                //Free Mem:0x 51002FB0  | Pointer: 0x01347EB4  | Origional Offset: 0x308F3534
                public static void EmpGrenadeDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51002FB0, new byte[] { 0x51, 0x00, 0x2F, 0xB0 }, textbox, 0x01347EB4);

                }

                //String: Shock Charge
                //Free Mem:0x 51003020  | Pointer: 0x01347F3C  | Origional Offset: 0x308F3865
                public static void ShockCharge(string textbox)
                {
                    FuncDank.ChangeString(0x51003020, new byte[] { 0x51, 0x00, 0x30, 0x20 }, textbox, 0x01347F3C);

                }

                //String: Proximity triggered mine that electrocutes and stuns nearby enemies.
                //Free Mem:0x 51003090  | Pointer: 0x01347F44 | Origional Offset: 0x308F388B
                public static void ShockChargeDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51003090, new byte[] { 0x51, 0x00, 0x30, 0x90 }, textbox, 0x01347F44);

                }

                //String: Black Hat
                //Free Mem:0x 51003100  | Pointer: 0x01349094 | Origional Offset: 0x308F9021
                public static void Blackhat(string textbox)
                {
                    FuncDank.ChangeString(0x51003100, new byte[] { 0x51, 0x00, 0x31, 0x00 }, textbox, 0x01349094);

                }

                //String: Hack equipment and care packages, or disable enemy vehicles.
                //Free Mem:0x 51003170  | Pointer: 0x0134909C  | Origional Offset: 0x308F903B 
                public static void BlackhatDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51003170, new byte[] { 0x51, 0x00, 0x31, 0x70 }, textbox, 0x0134909C);

                }

                //String: Flash Bang
                //Free Mem:0x 510031E0  | Pointer: 0x01347684 | Origional Offset: 0x308F08A2
                public static void Flashbang(string textbox)
                {
                    FuncDank.ChangeString(0x510031E0, new byte[] { 0x51, 0x00, 0x31, 0xE0 }, textbox, 0x01347684);

                }

                //String: Blinds enemies and impairs hearing.
                //Free Mem:0x 51003250  | Pointer: 0x0134768C  | Origional Offset: 0x308F08BD
                public static void FlashbangDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51003250, new byte[] { 0x51, 0x00, 0x32, 0x50 }, textbox, 0x0134768C);

                }

                //String: Trophy System
                //Free Mem:0x 510032C0  | Pointer: 0x01348F6C  | Origional Offset: 0x308F8BF4
                public static void TrophySystem(string textbox)
                {
                    FuncDank.ChangeString(0x510032C0, new byte[] { 0x51, 0x00, 0x32, 0xC0 }, textbox, 0x01348F6C);

                }

                //String: Destroys incoming enemy projectiles within 10 meters. Vehicle missiles have a chance to penetrate.
                //Free Mem:0x 51003330  | Pointer: 0x01348F74  | Origional Offset: 0x308F8C17
                public static void TrophySystemDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51003330, new byte[] { 0x51, 0x00, 0x33, 0x30 }, textbox, 0x01348F74);

                }

                //String: Tactical Insertion
                //Free Mem:0x 510033A0  | Pointer: 0x01347B24  | Origional Offset: 0x308F2088
                public static void TacInsert(string textbox)
                {
                    FuncDank.ChangeString(0x51002760, new byte[] { 0x51, 0x00, 0x33, 0xA0 }, textbox, 0x01347B24);

                }

                //String: Tactical Insertion
                //Free Mem:0x 51003410  | Pointer: 0x01347B24  | Origional Offset: 0x308F2088
                public static void TacInsertDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51003410, new byte[] { 0x51, 0x00, 0x34, 0x10 }, textbox, 0x01347B24);

                }



            }

            public class AssultRifles
            {
                //String : MTAR
                //Free Mem: 0x51003480  | Pointer: 0x01347CA4  | Origional Offset: 0x308F2947
                public static void MTAR(string textbox)
                {
                    FuncDank.ChangeString(0x51003480, new byte[] { 0x51, 0x00, 0x34, 0x80 }, textbox, 0x01347CA4);
                }

                //String : Fully automatic assault rifle.  Versatile and strong overall.
                //Free Mem: 0x51003480  | Pointer: 0x01347CF4  | Origional Offset: 0x308F2C11
                public static void MTARDesc(string textbox)
                {
                    FuncDank.ChangeString(0x510034F0, new byte[] { 0x51, 0x00, 0x34, 0xF0 }, textbox, 0x01347CF4);

                }

                //String: Type 25
                //Free Mem: 0x51003560  | Pointer: 0x01347C84  | Origional Offset: 0x308F28FC
                public static void Type25(string textbox)
                {
                    FuncDank.ChangeString(0x51003560, new byte[] { 0x51, 0x00, 0x35, 0x60 }, textbox, 0x01347C84);

                }

                //String: Fully automatic assault rifle. High rate of fire with moderate recoil.
                //Free Mem: 0x510035D0  | Pointer: 0x01347CD4  | Origional Offset: 0x308F2ACF
                public static void Type25Desc(string textbox)
                {
                    FuncDank.ChangeString(0x510035D0, new byte[] { 0x51, 0x00, 0x35, 0xD0 }, textbox, 0x01347CD4);

                }

                //String: SWAT-556
                //Free Mem: 0x51003640  | Pointer: 0x01347EBC  | Origional Offset: 0x308F3576
                public static void SWAT556(string textbox)
                {
                    FuncDank.ChangeString(0x51003640, new byte[] { 0x51, 0x00, 0x36, 0x40 }, textbox, 0x01347EBC);

                }

                //String: 3 round burst assault rilfe. High damage output in each burst.
                //Free Mem: 0x510036B0  | Pointer: 0x01347EC4  | Origional Offset: 0x308F358D
                public static void SWAT556Desc(string textbox)
                {
                    FuncDank.ChangeString(0x510036B0, new byte[] { 0x51, 0x00, 0x36, 0xB0 }, textbox, 0x01347EC4);

                }

                //String: FAL OSW
                //Free Mem: 0x51003720  | Pointer: 0x01348BEC  | Origional Offset: 0x308F79EA
                public static void FALOSW(string textbox)
                {
                    FuncDank.ChangeString(0x51003720, new byte[] { 0x51, 0x00, 0x37, 0x20 }, textbox, 0x01348BEC);

                }

                //String: Semi-automatic assault rifle. Light recoil with strong damage output.
                //Free Mem: 0x51003790  | Pointer: 0x01348BF4  | Origional Offset: 0x308F79FE
                public static void FALOSWDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51003790, new byte[] { 0x51, 0x00, 0x37, 0x90 }, textbox, 0x01348BF4);

                }

                //String: M27
                //Free Mem: 0x51003800  | Pointer: 0x?  | Origional Offset: 0x?
                public static void M27(string textbox)
                {
                    // FuncDank.ChangeString(0x51003800, new byte[] { 0x51, 0x00, 0x38, 0x00 }, textbox, 0x ?);

                }

                //String: Fully automatic assault rifle. Reduced recoil provides higher accuracy.
                //Free Mem: 0x51003870  | Pointer: 0x013482D4  | Origional Offset: 0x308F499A
                public static void M27Desc(string textbox)
                {
                    FuncDank.ChangeString(0x51003870, new byte[] { 0x51, 0x00, 0x38, 0x70 }, textbox, 0x013482D4);

                }

                //String: SCAR-H
                //Free Mem: 0x510038E0  | Pointer: 0x01347C8C  | Origional Offset: 0x308F2912
                public static void SCARH(string textbox)
                {
                    FuncDank.ChangeString(0x510038E0, new byte[] { 0x51, 0x00, 0x38, 0xE0 }, textbox, 0x01347C8C);

                }

                //String: Fully automatic assault rifle. Increased damage and range.
                //Free Mem: 0x51003950  | Pointer: 0x01347CDC  | Origional Offset: 0x308F2B2A
                public static void SCARHDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51003950, new byte[] { 0x51, 0x00, 0x39, 0x50 }, textbox, 0x01347CDC);

                }

                //String: SMR
                //Free Mem: 0x510039C0  | Pointer: 0x?  | Origional Offset: 0x?
                public static void SMR(string textbox)
                {
                    //FuncDank.ChangeString(0x510039C0, new byte[] { 0x51, 0x00, 0x39, 0xC0 }, textbox, 0x ?);

                }

                //String: Semi-automatic assault rifle. Highest damage per round in class.
                //Free Mem: 0x51003A30  | Pointer: 0x0134805C  | Origional Offset: 0x308F3DC5
                public static void SMRDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51003A30, new byte[] { 0x51, 0x00, 0x3A, 0x30 }, textbox, 0x0134805C);

                }

                //String: M8A1
                //Free Mem: 0x51003AA0  | Pointer: 0x01347C9C  | Origional Offset: 0x308F2937
                public static void M8A1(string textbox)
                {
                    FuncDank.ChangeString(0x51003AA0, new byte[] { 0x51, 0x00, 0x3A, 0xA0 }, textbox, 0x01347C9C);

                }

                //String: 4 round burst assault rifle. Bursts can be fired in quick succession
                //Free Mem: 0x51003B10  | Pointer: 0x01347CEC  | Origional Offset: 0x308F2BBA
                public static void M8A1Desc(string textbox)
                {
                    FuncDank.ChangeString(0x51003B10, new byte[] { 0x51, 0x00, 0x3B, 0x10 }, textbox, 0x01347CEC);

                }

                //String: AN-94
                //Free Mem: 0x51003B80  | Pointer: 0x013480B4  | Origional Offset: 0x308F3F8E
                public static void AN94(string textbox)
                {
                    FuncDank.ChangeString(0x51003B80, new byte[] { 0x51, 0x00, 0x3B, 0x80 }, textbox, 0x013480B4);

                }

                //String: Fully automatic assault rifle. the first 2 rounds of each burst are fired at a faster rate
                //Free Mem: 0x51003BF0  | Pointer: 0x0134830C  | Origional Offset: 0x308F4B85
                public static void AN94Desc(string textbox)
                {
                    FuncDank.ChangeString(0x51003BF0, new byte[] { 0x51, 0x00, 0x3B, 0xF0 }, textbox, 0x0134830C);

                }

                //String: ASSAULTRIFLES
                //Free Mem: 0x51003C60  | Pointer: 0x0134EA4C  | Origional Offset: 0x309188DB
                public static void AssaultFiles(string textbox)
                {
                    FuncDank.ChangeString(0x51003C60, new byte[] { 0x51, 0x00, 0x3C, 0x60 }, textbox, 0x0134EA4C);

                }



            }

            public class Shotguns
            {
                //String: R870 MCS
                //Free Mem: 0x51003CD0  | Pointer: 0x01343CBC  | Origional Offset: 0x3016A712
                public static void R870MCS(string textbox)
                {
                    FuncDank.ChangeString(0x51003CD0, new byte[] { 0x51, 0x00, 0x3C, 0xD0 }, textbox, 0x01343CBC);

                }

                //String: Pump action shotgun. Strong damage and range.
                //Free Mem: 0x51003D40  | Pointer: 0x013482E4  | Origional Offset: 0x308F4A39 
                public static void R870MCSDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51003D40, new byte[] { 0x51, 0x00, 0x3D, 0x40 }, textbox, 0x013482E4);

                }

                //String: S12
                //Free Mem: 0x51003DB0  | Pointer: 0x?  | Origional Offset: 0x?
                public static void S12(string textbox)
                {
                    //FuncDank.ChangeString(0x51003DB0, new byte[] { 0x51, 0x00, 0x3D, 0xB0 } , textbox, 0x?);

                }

                //String: Semi-automatic shotgun. Deadly at short range.
                //Free Mem: 0x51003E20  | Pointer: 0x013482DC  | Origional Offset: 0x308F49F5
                public static void S12Desc(string textbox)
                {
                    FuncDank.ChangeString(0x51003E20, new byte[] { 0x51, 0x00, 0x3E, 0x20 }, textbox, 0x013482DC);

                }

                //String: KSG
                //Free Mem: 0x51003E90  | Pointer: 0x?  | Origional Offset: 0x?
                public static void KSG(string textbox)
                {
                    //FuncDank.ChangeString(0x51003E90, new byte[] { 0x51, 0x00, 0x3E, 0x90 }, textbox, 0x ?);

                }

                //String: Pump action slug shotgun. Fires a single slug for high damage at longer ranges.
                //Free Mem: 0x51003F00  | Pointer: 0x01347CB4  | Origional Offset: 0x308F296D
                public static void KSGDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51003F00, new byte[] { 0x51, 0x00, 0x3F, 0x00 }, textbox, 0x01347CB4);

                }

                //String: M1216
                //Free Mem: 0x51003F70  | Pointer: 0x01347F2C  | Origional Offset: 0x308F380B
                public static void M1216(string textbox)
                {
                    FuncDank.ChangeString(0x51003F70, new byte[] { 0x51, 0x00, 0x3F, 0x70 }, textbox, 0x01347F2C);

                }

                //String: Fully automatic shotgun with a rechamber every 4 rounds.  
                //Free Mem: 0x51004050  | Pointer: 0x01348144  | Origional Offset: 0x308F415F
                public static void M1216Desc(string textbox)
                {
                    FuncDank.ChangeString(0x51004050, new byte[] { 0x51, 0x00, 0x40, 0x50 }, textbox, 0x01348144);

                }



            }

            public class LMGs
            {
                //String: Mk 48
                //Free Mem: 0x510040C0  | Pointer: 0x01347C94  | Origional Offset: 0x308F2925
                public static void MK48(string textbox)
                {
                    FuncDank.ChangeString(0x510040C0, new byte[] { 0x51, 0x00, 0x40, 0xC0 }, textbox, 0x01347C94);

                }

                //String: Fully automatic LMG. Increased damage and range.
                //Free Mem: 0x51004130  | Pointer: 0x01347C94  | Origional Offset: 0x308F2B77
                public static void MK48Desc(string textbox)
                {
                    FuncDank.ChangeString(0x51004130, new byte[] { 0x51, 0x00, 0x41, 0x30 }, textbox, 0x01347C94);

                }

                //String: QBB LSW
                //Free Mem: 0x510041A0  | Pointer: 0x01348124  | Origional Offset: 0x308F40CD
                public static void QBBLSW(string textbox)
                {
                    FuncDank.ChangeString(0x510041A0, new byte[] { 0x51, 0x00, 0x41, 0xA0 }, textbox, 0x01348124);

                }

                //String: Fully automatic LMG. Highest rate of fire in class.
                //Free Mem: 0x51004210  | Pointer: 0x0134831C  | Origional Offset: 0x308F4C50
                public static void QBBLSWDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51004210, new byte[] { 0x51, 0x00, 0x42, 0x10 }, textbox, 0x0134831C);

                }

                //String: LSAT
                //Free Mem: 0x51004280  | Pointer: 0x013477B4  | Origional Offset: 0x308F0EAF
                public static void LSAT(string textbox)
                {
                    FuncDank.ChangeString(0x51004280, new byte[] { 0x51, 0x00, 0x42, 0x80 }, textbox, 0x013477B4);

                }

                //String: Fully automatic LMG. Versatile and strong overall.
                //Free Mem: 0x510042F0  | Pointer: 0x01347F34  | Origional Offset: 0x308F3820
                public static void LSATDesc(string textbox)
                {
                    FuncDank.ChangeString(0x510042F0, new byte[] { 0x51, 0x00, 0x42, 0xF0 }, textbox, 0x01347F34);

                }

                //String: HAMR
                //Free Mem: 0x51004360  | Pointer: 0x0134812C  | Origional Offset: 0x308F40E2
                public static void HAMR(string textbox)
                {
                    FuncDank.ChangeString(0x51004360, new byte[] { 0x51, 0x00, 0x43, 0x60 }, textbox, 0x0134812C);

                }

                //String: Fully automatic LMG. Reduces recoil during sustained fire.
                //Free Mem: 0x510043D0  | Pointer: 0x0134931C  | Origional Offset: 0x308F9CF9
                public static void HAMRDesc(string textbox)
                {
                    FuncDank.ChangeString(0x510043D0, new byte[] { 0x51, 0x00, 0x43, 0xD0 }, textbox, 0x0134931C);

                }


            }

            public class Sniper
            {
                //String: SVU-AS
                //Free Mem: 0x510044B0  | Pointer: 0x01347C6C  | Origional Offset: 0x308F28C2
                public static void SVUAS(string textbox)
                {
                    FuncDank.ChangeString(0x510044B0, new byte[] { 0x51, 0x00, 0x44, 0xB0 }, textbox, 0x01347C6C);

                }

                //String: Semi-automatic sniper rifle. High fire rate with low recoil.
                //Free Mem: 0x51004520  | Pointer: 0x01347CBC  | Origional Offset: 0x308F29CE
                public static void SVUASDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51004520, new byte[] { 0x51, 0x00, 0x45, 0x20 }, textbox, 0x01347CBC);

                }

                //String: DSR 50
                //Free Mem: 0x51004590  | Pointer: 0x01347CAC  | Origional Offset: 0x308F2959
                public static void DSR50(string textbox)
                {
                    FuncDank.ChangeString(0x51004590, new byte[] { 0x51, 0x00, 0x45, 0x90 }, textbox, 0x01347CAC);

                }

                //String: Bolt-action sniper rifle. Deadly from the waist up.
                //Free Mem: 0x51004600  | Pointer: 0x01347CFC  | Origional Offset: 0x308F2C61
                public static void DSR50Desc(string textbox)
                {
                    FuncDank.ChangeString(0x51004600, new byte[] { 0x51, 0x00, 0x46, 0x00 }, textbox, 0x01347CFC);

                }

                //String: Ballista
                //Free Mem: 0x51004670  | Pointer: 0x01348ADC  | Origional Offset: 0x308F7427
                public static void Ballista(string textbox)
                {
                    FuncDank.ChangeString(0x51004670, new byte[] { 0x51, 0x00, 0x46, 0x70 }, textbox, 0x01348ADC);

                }

                //String: Bolt action sniper rifle. Deadly from the chest up, with faster handling speeds.
                //Free Mem: 0x510046E0  | Pointer: 0x01348AE4  | Origional Offset: 0x308F7440
                public static void BallistaDesc(string textbox)
                {
                    FuncDank.ChangeString(0x510046E0, new byte[] { 0x51, 0x00, 0x46, 0xE0 }, textbox, 0x01348AE4);

                }

                //String: XPR50
                //Free Mem: 0x51004750  | Pointer: 0x013489EC  | Origional Offset: 0x308F6F55
                public static void XPR50(string textbox)
                {
                    FuncDank.ChangeString(0x51004750, new byte[] { 0x51, 0x00, 0x47, 0x50 }, textbox, 0x013489EC);

                }

                //String: Semi-automatic sniper rifle. Deadly from the chest up, with moderate recoil.
                //Free Mem: 0x510047C0  | Pointer: 0x013489F4  | Origional Offset: 0x308F6F68
                public static void XPR50Desc(string textbox)
                {
                    FuncDank.ChangeString(0x510047C0, new byte[] { 0x51, 0x00, 0x47, 0xC0 }, textbox, 0x013489F4);

                }

            }

            public class PrimarySpecial
            {
                //String: AssaultShield
                //Free Mem: 0x510048A0  | Pointer: 0x01347E84  | Origional Offset: 0x308F33E9
                public static void AssaultShield(string textbox)
                {
                    FuncDank.ChangeString(0x510048A0, new byte[] { 0x51, 0x00, 0x48, 0xA0 }, textbox, 0x01347E84);

                }

                //String: Ballistic-proof blunt shield weapon. Can be deployed on the ground as cover.
                //Free Mem: 0x51004910  | Pointer: 0x01348264  | Origional Offset: 0x308F4676
                public static void AssaultShieldDesc(string textbox)
                {
                    FuncDank.ChangeString(0x51004910, new byte[] { 0x51, 0x00, 0x49, 0x10 }, textbox, 0x01348264);

                }

            }
        }

        public class PlayLists
        {
            public class Playlist
            {
                //String: PLAYLISTS
                //Free Mem: 0x51004D00  | Pointer: 0x01355704  | Origional Offset: 0x3093C458
                public static void StringPlaylists(string textbox)
                {
                    FuncDank.ChangeString(0x51004D00, new byte[] { 0x51, 0x00, 0x4D, 0x00 }, textbox, 0x01355704);
                }


            }

            public class Core
            {

            }

            public class Hardcore
            {

            }

            public class CombatTraining
            {

            }

            public class PartyGames
            {

            }
        }
    }
}
