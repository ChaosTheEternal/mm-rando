using MMR.Randomizer.Models.Settings;
using System;
using System.Drawing;
using System.Linq;

namespace MMR.UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bopen = new System.Windows.Forms.Button();
            openROM = new System.Windows.Forms.OpenFileDialog();
            openLogic = new System.Windows.Forms.OpenFileDialog();
            loadSettings = new System.Windows.Forms.OpenFileDialog();
            saveSettings = new System.Windows.Forms.SaveFileDialog();
            tROMName = new System.Windows.Forms.TextBox();
            tSettings = new System.Windows.Forms.TabControl();
            tabMain = new System.Windows.Forms.TabPage();
            tOtherCustomizations = new System.Windows.Forms.TabControl();
            tOtherCustomization = new System.Windows.Forms.TabPage();
            cStartingItems = new System.Windows.Forms.ComboBox();
            lStartingItems = new System.Windows.Forms.Label();
            cProgressiveUpgrades = new System.Windows.Forms.CheckBox();
            cDEnt = new System.Windows.Forms.CheckBox();
            cMixSongs = new System.Windows.Forms.CheckBox();
            cEnemy = new System.Windows.Forms.CheckBox();
            groupBox9 = new System.Windows.Forms.GroupBox();
            lNumTricksEnabled = new System.Windows.Forms.Label();
            lItemPlacement = new System.Windows.Forms.Label();
            cItemPlacement = new System.Windows.Forms.ComboBox();
            bToggleTricks = new System.Windows.Forms.Button();
            cMode = new System.Windows.Forms.ComboBox();
            bLoadLogic = new System.Windows.Forms.Button();
            lMode = new System.Windows.Forms.Label();
            tbUserLogic = new System.Windows.Forms.TextBox();
            groupBox6 = new System.Windows.Forms.GroupBox();
            tJunkLocationsList = new System.Windows.Forms.TextBox();
            bJunkLocationsEditor = new System.Windows.Forms.Button();
            lJunkLocationsAmount = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            tStartingItemList = new System.Windows.Forms.TextBox();
            lCustomStartingItemAmount = new System.Windows.Forms.Label();
            bStartingItemEditor = new System.Windows.Forms.Button();
            tabItemPool = new System.Windows.Forms.TabPage();
            cItemPoolAdvanced = new System.Windows.Forms.CheckBox();
            pClassicItemPool = new System.Windows.Forms.Panel();
            lItemPoolText = new System.Windows.Forms.Label();
            bItemPoolEdit = new System.Windows.Forms.Button();
            tItemPool = new System.Windows.Forms.TextBox();
            tableItemPool = new System.Windows.Forms.TableLayoutPanel();
            pLocationCategories = new System.Windows.Forms.Panel();
            tabGimmicks = new System.Windows.Forms.TabPage();
            groupBox12 = new System.Windows.Forms.GroupBox();
            cFreeScarecrow = new System.Windows.Forms.CheckBox();
            cFDAnywhere = new System.Windows.Forms.CheckBox();
            cBlastCooldown = new System.Windows.Forms.ComboBox();
            cUnderwaterOcarina = new System.Windows.Forms.CheckBox();
            cSunsSong = new System.Windows.Forms.CheckBox();
            lBlastMask = new System.Windows.Forms.Label();
            lNutAndStickDrops = new System.Windows.Forms.Label();
            cNutAndStickDrops = new System.Windows.Forms.ComboBox();
            groupBox11 = new System.Windows.Forms.GroupBox();
            cDType = new System.Windows.Forms.ComboBox();
            lDType = new System.Windows.Forms.Label();
            cDeathMoonCrash = new System.Windows.Forms.CheckBox();
            cByoAmmo = new System.Windows.Forms.CheckBox();
            cDMult = new System.Windows.Forms.ComboBox();
            lDMult = new System.Windows.Forms.Label();
            groupBox10 = new System.Windows.Forms.GroupBox();
            cClimbMostSurfaces = new System.Windows.Forms.CheckBox();
            cHookshotAnySurface = new System.Windows.Forms.CheckBox();
            cFloors = new System.Windows.Forms.ComboBox();
            lFloors = new System.Windows.Forms.Label();
            lGravity = new System.Windows.Forms.Label();
            cGravity = new System.Windows.Forms.ComboBox();
            cContinuousDekuHopping = new System.Windows.Forms.CheckBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            lIceTraps = new System.Windows.Forms.Label();
            cIceTraps = new System.Windows.Forms.ComboBox();
            cIceTrapsAppearance = new System.Windows.Forms.ComboBox();
            cIceTrapQuirks = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            cAutoInvert = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cClockSpeed = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            cHideClock = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            tabComfort = new System.Windows.Forms.TabPage();
            gHintsGeneral = new System.Windows.Forms.GroupBox();
            bCustomizeHintPriorities = new System.Windows.Forms.Button();
            cHintImportance = new System.Windows.Forms.CheckBox();
            cMixGaroWithGossip = new System.Windows.Forms.CheckBox();
            gGaroHints = new System.Windows.Forms.GroupBox();
            cFreeGaroHints = new System.Windows.Forms.CheckBox();
            cCustomGaroWoth = new System.Windows.Forms.CheckBox();
            nMaxGaroCT = new System.Windows.Forms.NumericUpDown();
            lGaroHints = new System.Windows.Forms.Label();
            nMaxGaroFoolish = new System.Windows.Forms.NumericUpDown();
            cGaroHint = new System.Windows.Forms.ComboBox();
            nMaxGaroWotH = new System.Windows.Forms.NumericUpDown();
            cClearGaroHints = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            gSpeedUps = new System.Windows.Forms.GroupBox();
            cDoubleArcheryRewards = new System.Windows.Forms.CheckBox();
            cFasterBank = new System.Windows.Forms.CheckBox();
            cSkipBeaver = new System.Windows.Forms.CheckBox();
            cFasterLabFish = new System.Windows.Forms.CheckBox();
            cGoodDogRaceRNG = new System.Windows.Forms.CheckBox();
            cGoodDampeRNG = new System.Windows.Forms.CheckBox();
            gHints = new System.Windows.Forms.GroupBox();
            cCustomGossipWoth = new System.Windows.Forms.CheckBox();
            nMaxGossipCT = new System.Windows.Forms.NumericUpDown();
            nMaxGossipFoolish = new System.Windows.Forms.NumericUpDown();
            nMaxGossipWotH = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lGossipWothConfig = new System.Windows.Forms.Label();
            lGossip = new System.Windows.Forms.Label();
            cGossipHints = new System.Windows.Forms.ComboBox();
            cFreeHints = new System.Windows.Forms.CheckBox();
            cClearHints = new System.Windows.Forms.CheckBox();
            groupBox8 = new System.Windows.Forms.GroupBox();
            lLink = new System.Windows.Forms.Label();
            cLink = new System.Windows.Forms.ComboBox();
            groupBox7 = new System.Windows.Forms.GroupBox();
            cInvisSparkle = new System.Windows.Forms.CheckBox();
            cFillWallet = new System.Windows.Forms.CheckBox();
            cTargetHealth = new System.Windows.Forms.CheckBox();
            cLenientGoronSpikes = new System.Windows.Forms.CheckBox();
            cImprovedPictobox = new System.Windows.Forms.CheckBox();
            cElegySpeedups = new System.Windows.Forms.CheckBox();
            cCloseCows = new System.Windows.Forms.CheckBox();
            cArrowCycling = new System.Windows.Forms.CheckBox();
            cFreestanding = new System.Windows.Forms.CheckBox();
            cFastPush = new System.Windows.Forms.CheckBox();
            cQText = new System.Windows.Forms.CheckBox();
            cShopAppearance = new System.Windows.Forms.CheckBox();
            cEponaSword = new System.Windows.Forms.CheckBox();
            cUpdateChests = new System.Windows.Forms.CheckBox();
            cDisableCritWiggle = new System.Windows.Forms.CheckBox();
            cQuestItemStorage = new System.Windows.Forms.CheckBox();
            cNoDowngrades = new System.Windows.Forms.CheckBox();
            tabShortenCutscenes = new System.Windows.Forms.TabPage();
            tShortenCutscenes = new System.Windows.Forms.TabControl();
            tabCosmetics = new System.Windows.Forms.TabPage();
            gCosmeticOther = new System.Windows.Forms.GroupBox();
            cInstantPictobox = new System.Windows.Forms.CheckBox();
            cTatl = new System.Windows.Forms.ComboBox();
            lTatl = new System.Windows.Forms.Label();
            cTargettingStyle = new System.Windows.Forms.CheckBox();
            gCosmeticMusicSound = new System.Windows.Forms.GroupBox();
            lLuckRoll = new System.Windows.Forms.Label();
            tLuckRollPercentage = new System.Windows.Forms.NumericUpDown();
            lMusic = new System.Windows.Forms.Label();
            cMusic = new System.Windows.Forms.ComboBox();
            cSFX = new System.Windows.Forms.CheckBox();
            cCombatMusicDisable = new System.Windows.Forms.CheckBox();
            cEnableNightMusic = new System.Windows.Forms.CheckBox();
            cLowHealthSFXComboBox = new System.Windows.Forms.ComboBox();
            lLowHealthSFXComboBox = new System.Windows.Forms.Label();
            cHUDGroupBox = new System.Windows.Forms.GroupBox();
            cHueShiftMiscUI = new System.Windows.Forms.CheckBox();
            cHUDTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            cHUDHeartsComboBox = new System.Windows.Forms.ComboBox();
            cHeartsLabel = new System.Windows.Forms.Label();
            cMagicLabel = new System.Windows.Forms.Label();
            cHUDMagicComboBox = new System.Windows.Forms.ComboBox();
            btn_hud = new System.Windows.Forms.Button();
            tFormCosmetics = new System.Windows.Forms.TabControl();
            cDrawHash = new System.Windows.Forms.CheckBox();
            gGameOutput = new System.Windows.Forms.GroupBox();
            cHTMLLog = new System.Windows.Forms.CheckBox();
            cPatch = new System.Windows.Forms.CheckBox();
            cSpoiler = new System.Windows.Forms.CheckBox();
            cN64 = new System.Windows.Forms.CheckBox();
            cVC = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            bApplyPatch = new System.Windows.Forms.Button();
            saveROM = new System.Windows.Forms.SaveFileDialog();
            cEnergy = new System.Windows.Forms.ColorDialog();
            cTunic = new System.Windows.Forms.ColorDialog();
            bRandomise = new System.Windows.Forms.Button();
            saveWad = new System.Windows.Forms.SaveFileDialog();
            mMenu = new System.Windows.Forms.MenuStrip();
            mFile = new System.Windows.Forms.ToolStripMenuItem();
            saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mExit = new System.Windows.Forms.ToolStripMenuItem();
            mCustomise = new System.Windows.Forms.ToolStripMenuItem();
            mDPadConfig = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mLogicEdit = new System.Windows.Forms.ToolStripMenuItem();
            mHelp = new System.Windows.Forms.ToolStripMenuItem();
            mManual = new System.Windows.Forms.ToolStripMenuItem();
            mSep1 = new System.Windows.Forms.ToolStripSeparator();
            mAbout = new System.Windows.Forms.ToolStripMenuItem();
            openBROM = new System.Windows.Forms.OpenFileDialog();
            pProgress = new System.Windows.Forms.ProgressBar();
            bgWorker = new System.ComponentModel.BackgroundWorker();
            lStatus = new System.Windows.Forms.Label();
            tSeed = new System.Windows.Forms.TextBox();
            lSeed = new System.Windows.Forms.Label();
            cDummy = new System.Windows.Forms.CheckBox();
            openPatch = new System.Windows.Forms.OpenFileDialog();
            ttOutput = new System.Windows.Forms.TabControl();
            tpOutputSettings = new System.Windows.Forms.TabPage();
            tService = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            tpPatchSettings = new System.Windows.Forms.TabPage();
            tPatch = new System.Windows.Forms.TextBox();
            bLoadPatch = new System.Windows.Forms.Button();
            bSkip = new System.Windows.Forms.Button();
            tSettings.SuspendLayout();
            tabMain.SuspendLayout();
            tOtherCustomizations.SuspendLayout();
            tOtherCustomization.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            tabItemPool.SuspendLayout();
            tabGimmicks.SuspendLayout();
            groupBox12.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            tabComfort.SuspendLayout();
            gHintsGeneral.SuspendLayout();
            gGaroHints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nMaxGaroCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nMaxGaroFoolish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nMaxGaroWotH).BeginInit();
            gSpeedUps.SuspendLayout();
            gHints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nMaxGossipCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nMaxGossipFoolish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nMaxGossipWotH).BeginInit();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            tabShortenCutscenes.SuspendLayout();
            tabCosmetics.SuspendLayout();
            gCosmeticOther.SuspendLayout();
            gCosmeticMusicSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tLuckRollPercentage).BeginInit();
            cHUDGroupBox.SuspendLayout();
            cHUDTableLayoutPanel.SuspendLayout();
            gGameOutput.SuspendLayout();
            mMenu.SuspendLayout();
            ttOutput.SuspendLayout();
            tpOutputSettings.SuspendLayout();
            tpPatchSettings.SuspendLayout();
            SuspendLayout();
            // 
            // bopen
            // 
            bopen.Location = new Point(14, 434);
            bopen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bopen.Name = "bopen";
            bopen.Size = new Size(112, 31);
            bopen.TabIndex = 0;
            bopen.Text = "Open ROM";
            bopen.UseVisualStyleBackColor = true;
            bopen.Click += bopen_Click;
            // 
            // openROM
            // 
            openROM.Filter = "ROM files|*.z64";
            // 
            // openLogic
            // 
            openLogic.Filter = "Logic File|*.txt";
            // 
            // tROMName
            // 
            tROMName.Location = new Point(138, 438);
            tROMName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tROMName.Name = "tROMName";
            tROMName.ReadOnly = true;
            tROMName.Size = new Size(639, 23);
            tROMName.TabIndex = 1;
            // 
            // tSettings
            // 
            tSettings.Controls.Add(tabMain);
            tSettings.Controls.Add(tabItemPool);
            tSettings.Controls.Add(tabGimmicks);
            tSettings.Controls.Add(tabComfort);
            tSettings.Controls.Add(tabShortenCutscenes);
            tSettings.Controls.Add(tabCosmetics);
            tSettings.Location = new Point(4, 28);
            tSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tSettings.Name = "tSettings";
            tSettings.SelectedIndex = 0;
            tSettings.Size = new Size(788, 389);
            tSettings.TabIndex = 10;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tOtherCustomizations);
            tabMain.Controls.Add(groupBox9);
            tabMain.Controls.Add(groupBox6);
            tabMain.Controls.Add(groupBox4);
            tabMain.Location = new Point(4, 24);
            tabMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabMain.Name = "tabMain";
            tabMain.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabMain.Size = new Size(780, 361);
            tabMain.TabIndex = 0;
            tabMain.Text = "Main Settings";
            tabMain.UseVisualStyleBackColor = true;
            // 
            // tOtherCustomizations
            // 
            tOtherCustomizations.Controls.Add(tOtherCustomization);
            tOtherCustomizations.Location = new Point(7, 146);
            tOtherCustomizations.Name = "tOtherCustomizations";
            tOtherCustomizations.SelectedIndex = 0;
            tOtherCustomizations.Size = new Size(381, 160);
            tOtherCustomizations.TabIndex = 22;
            // 
            // tOtherCustomization
            // 
            tOtherCustomization.Controls.Add(cStartingItems);
            tOtherCustomization.Controls.Add(lStartingItems);
            tOtherCustomization.Controls.Add(cProgressiveUpgrades);
            tOtherCustomization.Controls.Add(cDEnt);
            tOtherCustomization.Controls.Add(cMixSongs);
            tOtherCustomization.Controls.Add(cEnemy);
            tOtherCustomization.Location = new Point(4, 24);
            tOtherCustomization.Name = "tOtherCustomization";
            tOtherCustomization.Padding = new System.Windows.Forms.Padding(3);
            tOtherCustomization.Size = new Size(373, 132);
            tOtherCustomization.TabIndex = 0;
            tOtherCustomization.Text = "Other";
            tOtherCustomization.UseVisualStyleBackColor = true;
            // 
            // cStartingItems
            // 
            cStartingItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cStartingItems.FormattingEnabled = true;
            cStartingItems.Items.AddRange(new object[] { "None", "Random", "Allow Temporary Items" });
            cStartingItems.Location = new Point(6, 71);
            cStartingItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cStartingItems.Name = "cStartingItems";
            cStartingItems.Size = new Size(160, 23);
            cStartingItems.TabIndex = 27;
            cStartingItems.SelectedIndexChanged += cStartingItems_SelectedIndexChanged;
            // 
            // lStartingItems
            // 
            lStartingItems.AutoSize = true;
            lStartingItems.Location = new Point(6, 56);
            lStartingItems.Name = "lStartingItems";
            lStartingItems.Size = new Size(80, 15);
            lStartingItems.TabIndex = 22;
            lStartingItems.Text = "Starting Items";
            // 
            // cProgressiveUpgrades
            // 
            cProgressiveUpgrades.AutoSize = true;
            cProgressiveUpgrades.BackColor = Color.Transparent;
            cProgressiveUpgrades.ForeColor = Color.Black;
            cProgressiveUpgrades.Location = new Point(193, 10);
            cProgressiveUpgrades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cProgressiveUpgrades.Name = "cProgressiveUpgrades";
            cProgressiveUpgrades.Size = new Size(139, 19);
            cProgressiveUpgrades.TabIndex = 21;
            cProgressiveUpgrades.Text = "Progressive Upgrades";
            cProgressiveUpgrades.UseVisualStyleBackColor = false;
            cProgressiveUpgrades.CheckedChanged += cProgressiveUpgrades_CheckedChanged;
            // 
            // cDEnt
            // 
            cDEnt.AutoSize = true;
            cDEnt.BackColor = Color.Transparent;
            cDEnt.ForeColor = Color.Black;
            cDEnt.Location = new Point(6, 10);
            cDEnt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cDEnt.Name = "cDEnt";
            cDEnt.Size = new Size(129, 19);
            cDEnt.TabIndex = 7;
            cDEnt.Text = "Dungeon entrances";
            cDEnt.UseVisualStyleBackColor = false;
            cDEnt.CheckedChanged += cDEnt_CheckedChanged;
            // 
            // cMixSongs
            // 
            cMixSongs.AutoSize = true;
            cMixSongs.BackColor = Color.Transparent;
            cMixSongs.ForeColor = Color.Black;
            cMixSongs.Location = new Point(6, 36);
            cMixSongs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cMixSongs.Name = "cMixSongs";
            cMixSongs.Size = new Size(138, 19);
            cMixSongs.TabIndex = 3;
            cMixSongs.Text = "Mix songs with items";
            cMixSongs.UseVisualStyleBackColor = false;
            cMixSongs.CheckedChanged += cMixSongs_CheckedChanged;
            // 
            // cEnemy
            // 
            cEnemy.AutoSize = true;
            cEnemy.BackColor = Color.Transparent;
            cEnemy.ForeColor = Color.Black;
            cEnemy.Location = new Point(193, 36);
            cEnemy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cEnemy.Name = "cEnemy";
            cEnemy.Size = new Size(110, 19);
            cEnemy.TabIndex = 9;
            cEnemy.Text = "Enemies (BETA!)";
            cEnemy.UseVisualStyleBackColor = false;
            cEnemy.CheckedChanged += cEnemy_CheckedChanged;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(lNumTricksEnabled);
            groupBox9.Controls.Add(lItemPlacement);
            groupBox9.Controls.Add(cItemPlacement);
            groupBox9.Controls.Add(bToggleTricks);
            groupBox9.Controls.Add(cMode);
            groupBox9.Controls.Add(bLoadLogic);
            groupBox9.Controls.Add(lMode);
            groupBox9.Controls.Add(tbUserLogic);
            groupBox9.Location = new Point(7, 7);
            groupBox9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox9.Size = new Size(379, 133);
            groupBox9.TabIndex = 29;
            groupBox9.TabStop = false;
            groupBox9.Text = "Generation Settings";
            // 
            // lNumTricksEnabled
            // 
            lNumTricksEnabled.Location = new Point(96, 22);
            lNumTricksEnabled.Name = "lNumTricksEnabled";
            lNumTricksEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lNumTricksEnabled.Size = new Size(271, 18);
            lNumTricksEnabled.TabIndex = 21;
            lNumTricksEnabled.Text = "0 tricks enabled";
            // 
            // lItemPlacement
            // 
            lItemPlacement.AutoSize = true;
            lItemPlacement.BackColor = Color.Transparent;
            lItemPlacement.ForeColor = Color.Black;
            lItemPlacement.Location = new Point(13, 111);
            lItemPlacement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lItemPlacement.Name = "lItemPlacement";
            lItemPlacement.Size = new Size(126, 15);
            lItemPlacement.TabIndex = 21;
            lItemPlacement.Text = "Item Placement Order:";
            // 
            // cItemPlacement
            // 
            cItemPlacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cItemPlacement.FormattingEnabled = true;
            cItemPlacement.Items.AddRange(new object[] { "Random", "Bespoke", "Classic" });
            cItemPlacement.Location = new Point(142, 104);
            cItemPlacement.Name = "cItemPlacement";
            cItemPlacement.Size = new Size(121, 23);
            cItemPlacement.TabIndex = 20;
            cItemPlacement.SelectedIndexChanged += cItemPlacement_SelectedIndexChanged;
            // 
            // bToggleTricks
            // 
            bToggleTricks.Location = new Point(271, 39);
            bToggleTricks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bToggleTricks.Name = "bToggleTricks";
            bToggleTricks.Size = new Size(96, 27);
            bToggleTricks.TabIndex = 19;
            bToggleTricks.Text = "Edit Tricks";
            bToggleTricks.UseVisualStyleBackColor = true;
            bToggleTricks.Click += bToggleTricks_Click;
            // 
            // cMode
            // 
            cMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cMode.FormattingEnabled = true;
            cMode.Items.AddRange(new object[] { "Casual", "Glitched", "Vanilla Layout", "User Logic", "No Logic" });
            cMode.Location = new Point(96, 40);
            cMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cMode.Name = "cMode";
            cMode.Size = new Size(167, 23);
            cMode.TabIndex = 1;
            cMode.SelectedIndexChanged += cMode_SelectedIndexChanged;
            // 
            // bLoadLogic
            // 
            bLoadLogic.Location = new Point(13, 71);
            bLoadLogic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bLoadLogic.Name = "bLoadLogic";
            bLoadLogic.Size = new Size(79, 28);
            bLoadLogic.TabIndex = 17;
            bLoadLogic.Text = "Open Logic";
            bLoadLogic.UseVisualStyleBackColor = true;
            bLoadLogic.Click += bLoadLogic_Click;
            // 
            // lMode
            // 
            lMode.AutoSize = true;
            lMode.BackColor = Color.Transparent;
            lMode.ForeColor = Color.Black;
            lMode.Location = new Point(10, 43);
            lMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lMode.Name = "lMode";
            lMode.Size = new Size(75, 15);
            lMode.TabIndex = 0;
            lMode.Text = "Mode/Logic:";
            // 
            // tbUserLogic
            // 
            tbUserLogic.Location = new Point(96, 74);
            tbUserLogic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbUserLogic.Name = "tbUserLogic";
            tbUserLogic.ReadOnly = true;
            tbUserLogic.Size = new Size(271, 23);
            tbUserLogic.TabIndex = 18;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tJunkLocationsList);
            groupBox6.Controls.Add(bJunkLocationsEditor);
            groupBox6.Controls.Add(lJunkLocationsAmount);
            groupBox6.Location = new Point(394, 96);
            groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Size = new Size(377, 83);
            groupBox6.TabIndex = 28;
            groupBox6.TabStop = false;
            groupBox6.Text = "Enforce Junk Locations";
            // 
            // tJunkLocationsList
            // 
            tJunkLocationsList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tJunkLocationsList.Location = new Point(13, 51);
            tJunkLocationsList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tJunkLocationsList.Name = "tJunkLocationsList";
            tJunkLocationsList.Size = new Size(309, 23);
            tJunkLocationsList.TabIndex = 26;
            tJunkLocationsList.Text = "--";
            tJunkLocationsList.TextChanged += tJunkLocationsList_TextChanged;
            // 
            // bJunkLocationsEditor
            // 
            bJunkLocationsEditor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bJunkLocationsEditor.Location = new Point(319, 50);
            bJunkLocationsEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bJunkLocationsEditor.Name = "bJunkLocationsEditor";
            bJunkLocationsEditor.Size = new Size(46, 25);
            bJunkLocationsEditor.TabIndex = 26;
            bJunkLocationsEditor.Text = "Edit";
            bJunkLocationsEditor.UseVisualStyleBackColor = true;
            bJunkLocationsEditor.Click += bJunkLocationsEditor_Click;
            // 
            // lJunkLocationsAmount
            // 
            lJunkLocationsAmount.AutoSize = true;
            lJunkLocationsAmount.Location = new Point(10, 28);
            lJunkLocationsAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lJunkLocationsAmount.Name = "lJunkLocationsAmount";
            lJunkLocationsAmount.Size = new Size(121, 15);
            lJunkLocationsAmount.TabIndex = 27;
            lJunkLocationsAmount.Text = "0/0 locations selected";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tStartingItemList);
            groupBox4.Controls.Add(lCustomStartingItemAmount);
            groupBox4.Controls.Add(bStartingItemEditor);
            groupBox4.Location = new Point(394, 7);
            groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(377, 83);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Extra Starting Items";
            // 
            // tStartingItemList
            // 
            tStartingItemList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tStartingItemList.Location = new Point(13, 52);
            tStartingItemList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tStartingItemList.Name = "tStartingItemList";
            tStartingItemList.Size = new Size(309, 23);
            tStartingItemList.TabIndex = 26;
            tStartingItemList.Text = "--";
            tStartingItemList.TextChanged += tStartingItemList_TextChanged;
            // 
            // lCustomStartingItemAmount
            // 
            lCustomStartingItemAmount.AutoSize = true;
            lCustomStartingItemAmount.Location = new Point(10, 29);
            lCustomStartingItemAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lCustomStartingItemAmount.Name = "lCustomStartingItemAmount";
            lCustomStartingItemAmount.Size = new Size(102, 15);
            lCustomStartingItemAmount.TabIndex = 27;
            lCustomStartingItemAmount.Text = "0/0 items selected";
            // 
            // bStartingItemEditor
            // 
            bStartingItemEditor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bStartingItemEditor.Location = new Point(320, 51);
            bStartingItemEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bStartingItemEditor.Name = "bStartingItemEditor";
            bStartingItemEditor.Size = new Size(46, 25);
            bStartingItemEditor.TabIndex = 26;
            bStartingItemEditor.Text = "Edit";
            bStartingItemEditor.UseVisualStyleBackColor = true;
            bStartingItemEditor.Click += bStartingItemEditor_Click;
            // 
            // tabItemPool
            // 
            tabItemPool.Controls.Add(cItemPoolAdvanced);
            tabItemPool.Controls.Add(pClassicItemPool);
            tabItemPool.Controls.Add(lItemPoolText);
            tabItemPool.Controls.Add(bItemPoolEdit);
            tabItemPool.Controls.Add(tItemPool);
            tabItemPool.Controls.Add(tableItemPool);
            tabItemPool.Controls.Add(pLocationCategories);
            tabItemPool.Location = new Point(4, 24);
            tabItemPool.Name = "tabItemPool";
            tabItemPool.Size = new Size(780, 361);
            tabItemPool.TabIndex = 6;
            tabItemPool.Text = "Item Randomization";
            tabItemPool.UseVisualStyleBackColor = true;
            // 
            // cItemPoolAdvanced
            // 
            cItemPoolAdvanced.AutoSize = true;
            cItemPoolAdvanced.Location = new Point(7, 52);
            cItemPoolAdvanced.Name = "cItemPoolAdvanced";
            cItemPoolAdvanced.Size = new Size(107, 19);
            cItemPoolAdvanced.TabIndex = 27;
            cItemPoolAdvanced.Text = "Advanced View";
            cItemPoolAdvanced.UseVisualStyleBackColor = true;
            cItemPoolAdvanced.CheckedChanged += cItemPoolAdvanced_CheckedChanged;
            // 
            // pClassicItemPool
            // 
            pClassicItemPool.Location = new Point(7, 77);
            pClassicItemPool.Name = "pClassicItemPool";
            pClassicItemPool.Size = new Size(765, 281);
            pClassicItemPool.TabIndex = 26;
            // 
            // lItemPoolText
            // 
            lItemPoolText.AutoSize = true;
            lItemPoolText.Location = new Point(7, 34);
            lItemPoolText.Name = "lItemPoolText";
            lItemPoolText.Size = new Size(122, 15);
            lItemPoolText.TabIndex = 25;
            lItemPoolText.Text = "0/0 items randomized";
            // 
            // bItemPoolEdit
            // 
            bItemPoolEdit.Location = new Point(697, 3);
            bItemPoolEdit.Name = "bItemPoolEdit";
            bItemPoolEdit.Size = new Size(75, 25);
            bItemPoolEdit.TabIndex = 24;
            bItemPoolEdit.Text = "Edit";
            bItemPoolEdit.UseVisualStyleBackColor = true;
            bItemPoolEdit.Click += bItemPoolEdit_Click;
            // 
            // tItemPool
            // 
            tItemPool.Location = new Point(7, 4);
            tItemPool.Name = "tItemPool";
            tItemPool.Size = new Size(684, 23);
            tItemPool.TabIndex = 23;
            tItemPool.TextChanged += tItemPool_TextChanged;
            // 
            // tableItemPool
            // 
            tableItemPool.AutoScroll = true;
            tableItemPool.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableItemPool.ColumnCount = 1;
            tableItemPool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableItemPool.Location = new Point(3, 160);
            tableItemPool.Name = "tableItemPool";
            tableItemPool.RowCount = 1;
            tableItemPool.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableItemPool.Size = new Size(774, 198);
            tableItemPool.TabIndex = 22;
            tableItemPool.Visible = false;
            // 
            // pLocationCategories
            // 
            pLocationCategories.Location = new Point(7, 30);
            pLocationCategories.Name = "pLocationCategories";
            pLocationCategories.Size = new Size(770, 129);
            pLocationCategories.TabIndex = 28;
            pLocationCategories.Visible = false;
            // 
            // tabGimmicks
            // 
            tabGimmicks.Controls.Add(groupBox12);
            tabGimmicks.Controls.Add(groupBox11);
            tabGimmicks.Controls.Add(groupBox10);
            tabGimmicks.Controls.Add(groupBox5);
            tabGimmicks.Controls.Add(groupBox1);
            tabGimmicks.Controls.Add(label4);
            tabGimmicks.Location = new Point(4, 24);
            tabGimmicks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabGimmicks.Name = "tabGimmicks";
            tabGimmicks.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabGimmicks.Size = new Size(780, 361);
            tabGimmicks.TabIndex = 3;
            tabGimmicks.Text = "Gimmicks";
            tabGimmicks.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(cFreeScarecrow);
            groupBox12.Controls.Add(cFDAnywhere);
            groupBox12.Controls.Add(cBlastCooldown);
            groupBox12.Controls.Add(cUnderwaterOcarina);
            groupBox12.Controls.Add(cSunsSong);
            groupBox12.Controls.Add(lBlastMask);
            groupBox12.Controls.Add(lNutAndStickDrops);
            groupBox12.Controls.Add(cNutAndStickDrops);
            groupBox12.Location = new Point(189, 92);
            groupBox12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox12.Name = "groupBox12";
            groupBox12.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox12.Size = new Size(377, 260);
            groupBox12.TabIndex = 34;
            groupBox12.TabStop = false;
            groupBox12.Text = "Other";
            // 
            // cFreeScarecrow
            // 
            cFreeScarecrow.AutoSize = true;
            cFreeScarecrow.BackColor = Color.Transparent;
            cFreeScarecrow.ForeColor = Color.Black;
            cFreeScarecrow.Location = new Point(148, 100);
            cFreeScarecrow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cFreeScarecrow.Name = "cFreeScarecrow";
            cFreeScarecrow.Size = new Size(143, 19);
            cFreeScarecrow.TabIndex = 27;
            cFreeScarecrow.Text = "Free Scarecrow's Song";
            cFreeScarecrow.UseVisualStyleBackColor = false;
            cFreeScarecrow.CheckedChanged += cFreeScarecrow_CheckedChanged;
            // 
            // cFDAnywhere
            // 
            cFDAnywhere.AutoSize = true;
            cFDAnywhere.BackColor = Color.Transparent;
            cFDAnywhere.ForeColor = Color.Black;
            cFDAnywhere.Location = new Point(148, 75);
            cFDAnywhere.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cFDAnywhere.Name = "cFDAnywhere";
            cFDAnywhere.Size = new Size(213, 19);
            cFDAnywhere.TabIndex = 23;
            cFDAnywhere.Text = "Allow Fierce Deity's Mask anywhere";
            cFDAnywhere.UseVisualStyleBackColor = false;
            cFDAnywhere.CheckedChanged += cFDAnywhere_CheckedChanged;
            // 
            // cBlastCooldown
            // 
            cBlastCooldown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBlastCooldown.FormattingEnabled = true;
            cBlastCooldown.Items.AddRange(new object[] { "Default", "Instant", "Very short", "Short", "Long", "Very Long" });
            cBlastCooldown.Location = new Point(7, 35);
            cBlastCooldown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cBlastCooldown.Name = "cBlastCooldown";
            cBlastCooldown.Size = new Size(123, 23);
            cBlastCooldown.TabIndex = 20;
            cBlastCooldown.SelectedIndexChanged += cBlastCooldown_SelectedIndexChanged;
            // 
            // cUnderwaterOcarina
            // 
            cUnderwaterOcarina.AutoSize = true;
            cUnderwaterOcarina.BackColor = Color.Transparent;
            cUnderwaterOcarina.Location = new Point(148, 22);
            cUnderwaterOcarina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cUnderwaterOcarina.Name = "cUnderwaterOcarina";
            cUnderwaterOcarina.Size = new Size(131, 19);
            cUnderwaterOcarina.TabIndex = 22;
            cUnderwaterOcarina.Text = "Underwater Ocarina";
            cUnderwaterOcarina.UseVisualStyleBackColor = false;
            cUnderwaterOcarina.CheckedChanged += cUnderwaterOcarina_CheckedChanged;
            // 
            // cSunsSong
            // 
            cSunsSong.AutoSize = true;
            cSunsSong.BackColor = Color.Transparent;
            cSunsSong.ForeColor = Color.Black;
            cSunsSong.Location = new Point(148, 48);
            cSunsSong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cSunsSong.Name = "cSunsSong";
            cSunsSong.Size = new Size(122, 19);
            cSunsSong.TabIndex = 21;
            cSunsSong.Text = "Enable Sun's Song";
            cSunsSong.UseVisualStyleBackColor = false;
            cSunsSong.CheckedChanged += cSunsSong_CheckedChanged;
            // 
            // lBlastMask
            // 
            lBlastMask.AutoSize = true;
            lBlastMask.Location = new Point(8, 18);
            lBlastMask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lBlastMask.Name = "lBlastMask";
            lBlastMask.Size = new Size(121, 15);
            lBlastMask.TabIndex = 19;
            lBlastMask.Text = "Blast Mask Cooldown";
            // 
            // lNutAndStickDrops
            // 
            lNutAndStickDrops.AutoSize = true;
            lNutAndStickDrops.Location = new Point(8, 62);
            lNutAndStickDrops.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lNutAndStickDrops.Name = "lNutAndStickDrops";
            lNutAndStickDrops.Size = new Size(112, 15);
            lNutAndStickDrops.TabIndex = 25;
            lNutAndStickDrops.Text = "Nut and Stick Drops";
            // 
            // cNutAndStickDrops
            // 
            cNutAndStickDrops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cNutAndStickDrops.FormattingEnabled = true;
            cNutAndStickDrops.Items.AddRange(new object[] { "Default", "Light", "Medium", "Extra", "Mayhem" });
            cNutAndStickDrops.Location = new Point(7, 78);
            cNutAndStickDrops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cNutAndStickDrops.Name = "cNutAndStickDrops";
            cNutAndStickDrops.Size = new Size(123, 23);
            cNutAndStickDrops.TabIndex = 26;
            cNutAndStickDrops.SelectedIndexChanged += cNutAndStickDrops_SelectedIndexChanged;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(cDType);
            groupBox11.Controls.Add(lDType);
            groupBox11.Controls.Add(cDeathMoonCrash);
            groupBox11.Controls.Add(cByoAmmo);
            groupBox11.Controls.Add(cDMult);
            groupBox11.Controls.Add(lDMult);
            groupBox11.Location = new Point(8, 187);
            groupBox11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox11.Size = new Size(174, 164);
            groupBox11.TabIndex = 33;
            groupBox11.TabStop = false;
            groupBox11.Text = "Challenges";
            // 
            // cDType
            // 
            cDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cDType.FormattingEnabled = true;
            cDType.Items.AddRange(new object[] { "Default", "Fire", "Ice", "Shock", "Knockdown", "Random" });
            cDType.Location = new Point(7, 82);
            cDType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cDType.Name = "cDType";
            cDType.Size = new Size(159, 23);
            cDType.TabIndex = 0;
            cDType.SelectedIndexChanged += cDType_SelectedIndexChanged;
            // 
            // lDType
            // 
            lDType.AutoSize = true;
            lDType.Location = new Point(7, 66);
            lDType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lDType.Name = "lDType";
            lDType.Size = new Size(89, 15);
            lDType.TabIndex = 1;
            lDType.Text = "Damage effects";
            // 
            // cDeathMoonCrash
            // 
            cDeathMoonCrash.AutoSize = true;
            cDeathMoonCrash.BackColor = Color.Transparent;
            cDeathMoonCrash.ForeColor = Color.Black;
            cDeathMoonCrash.Location = new Point(7, 113);
            cDeathMoonCrash.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cDeathMoonCrash.Name = "cDeathMoonCrash";
            cDeathMoonCrash.Size = new Size(136, 19);
            cDeathMoonCrash.TabIndex = 25;
            cDeathMoonCrash.Text = "Death is Moon Crash";
            cDeathMoonCrash.UseVisualStyleBackColor = false;
            cDeathMoonCrash.CheckedChanged += cDeathMoonCrash_CheckedChanged;
            // 
            // cByoAmmo
            // 
            cByoAmmo.AutoSize = true;
            cByoAmmo.BackColor = Color.Transparent;
            cByoAmmo.ForeColor = Color.Black;
            cByoAmmo.Location = new Point(7, 140);
            cByoAmmo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cByoAmmo.Name = "cByoAmmo";
            cByoAmmo.Size = new Size(89, 19);
            cByoAmmo.TabIndex = 24;
            cByoAmmo.Text = "BYO Ammo";
            cByoAmmo.UseVisualStyleBackColor = false;
            cByoAmmo.CheckedChanged += cByoAmmo_CheckedChanged;
            // 
            // cDMult
            // 
            cDMult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cDMult.FormattingEnabled = true;
            cDMult.Items.AddRange(new object[] { "Default", "2x", "4x", "1-hit KO", "Doom" });
            cDMult.Location = new Point(7, 38);
            cDMult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cDMult.Name = "cDMult";
            cDMult.Size = new Size(159, 23);
            cDMult.TabIndex = 0;
            cDMult.SelectedIndexChanged += cDMult_SelectedIndexChanged;
            // 
            // lDMult
            // 
            lDMult.AutoSize = true;
            lDMult.Location = new Point(7, 22);
            lDMult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lDMult.Name = "lDMult";
            lDMult.Size = new Size(85, 15);
            lDMult.TabIndex = 1;
            lDMult.Text = "Damage mode";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(cClimbMostSurfaces);
            groupBox10.Controls.Add(cHookshotAnySurface);
            groupBox10.Controls.Add(cFloors);
            groupBox10.Controls.Add(lFloors);
            groupBox10.Controls.Add(lGravity);
            groupBox10.Controls.Add(cGravity);
            groupBox10.Controls.Add(cContinuousDekuHopping);
            groupBox10.Location = new Point(573, 7);
            groupBox10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox10.Size = new Size(198, 193);
            groupBox10.TabIndex = 32;
            groupBox10.TabStop = false;
            groupBox10.Text = "Movement";
            // 
            // cClimbMostSurfaces
            // 
            cClimbMostSurfaces.AutoSize = true;
            cClimbMostSurfaces.BackColor = Color.Transparent;
            cClimbMostSurfaces.ForeColor = Color.Black;
            cClimbMostSurfaces.Location = new Point(7, 160);
            cClimbMostSurfaces.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cClimbMostSurfaces.Name = "cClimbMostSurfaces";
            cClimbMostSurfaces.Size = new Size(135, 19);
            cClimbMostSurfaces.TabIndex = 28;
            cClimbMostSurfaces.Text = "Climb Most Surfaces";
            cClimbMostSurfaces.UseVisualStyleBackColor = false;
            cClimbMostSurfaces.CheckedChanged += cClimbMostSurfaces_CheckedChanged;
            // 
            // cHookshotAnySurface
            // 
            cHookshotAnySurface.AutoSize = true;
            cHookshotAnySurface.BackColor = Color.Transparent;
            cHookshotAnySurface.ForeColor = Color.Black;
            cHookshotAnySurface.Location = new Point(7, 135);
            cHookshotAnySurface.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cHookshotAnySurface.Name = "cHookshotAnySurface";
            cHookshotAnySurface.Size = new Size(144, 19);
            cHookshotAnySurface.TabIndex = 27;
            cHookshotAnySurface.Text = "Hookshot Any Surface";
            cHookshotAnySurface.UseVisualStyleBackColor = false;
            cHookshotAnySurface.CheckedChanged += cHookshotAnySurface_CheckedChanged;
            // 
            // cFloors
            // 
            cFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cFloors.FormattingEnabled = true;
            cFloors.Items.AddRange(new object[] { "Default", "Sand", "Ice", "Snow", "Random" });
            cFloors.Location = new Point(7, 78);
            cFloors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cFloors.Name = "cFloors";
            cFloors.Size = new Size(184, 23);
            cFloors.TabIndex = 0;
            cFloors.SelectedIndexChanged += cFloors_SelectedIndexChanged;
            // 
            // lFloors
            // 
            lFloors.AutoSize = true;
            lFloors.Location = new Point(7, 62);
            lFloors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lFloors.Name = "lFloors";
            lFloors.Size = new Size(65, 15);
            lFloors.TabIndex = 1;
            lFloors.Text = "Floor types";
            // 
            // lGravity
            // 
            lGravity.AutoSize = true;
            lGravity.Location = new Point(7, 18);
            lGravity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lGravity.Name = "lGravity";
            lGravity.Size = new Size(87, 15);
            lGravity.TabIndex = 1;
            lGravity.Text = "Gravity / Speed";
            // 
            // cGravity
            // 
            cGravity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cGravity.FormattingEnabled = true;
            cGravity.Items.AddRange(new object[] { "Default", "High speed (many softlocks)", "Super low gravity", "Low gravity", "High gravity" });
            cGravity.Location = new Point(7, 35);
            cGravity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cGravity.Name = "cGravity";
            cGravity.Size = new Size(184, 23);
            cGravity.TabIndex = 0;
            cGravity.SelectedIndexChanged += cGravity_SelectedIndexChanged;
            // 
            // cContinuousDekuHopping
            // 
            cContinuousDekuHopping.AutoSize = true;
            cContinuousDekuHopping.BackColor = Color.Transparent;
            cContinuousDekuHopping.ForeColor = Color.Black;
            cContinuousDekuHopping.Location = new Point(7, 110);
            cContinuousDekuHopping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cContinuousDekuHopping.Name = "cContinuousDekuHopping";
            cContinuousDekuHopping.Size = new Size(168, 19);
            cContinuousDekuHopping.TabIndex = 26;
            cContinuousDekuHopping.Text = "Continuous Deku Hopping";
            cContinuousDekuHopping.UseVisualStyleBackColor = false;
            cContinuousDekuHopping.CheckedChanged += cContinuousDekuHopping_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(lIceTraps);
            groupBox5.Controls.Add(cIceTraps);
            groupBox5.Controls.Add(cIceTrapsAppearance);
            groupBox5.Controls.Add(cIceTrapQuirks);
            groupBox5.Location = new Point(7, 7);
            groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(175, 174);
            groupBox5.TabIndex = 31;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ice Traps";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 62);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 30;
            label2.Text = "Appearance";
            // 
            // lIceTraps
            // 
            lIceTraps.AutoSize = true;
            lIceTraps.Location = new Point(7, 18);
            lIceTraps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lIceTraps.Name = "lIceTraps";
            lIceTraps.Size = new Size(51, 15);
            lIceTraps.TabIndex = 28;
            lIceTraps.Text = "Amount";
            // 
            // cIceTraps
            // 
            cIceTraps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cIceTraps.FormattingEnabled = true;
            cIceTraps.Items.AddRange(new object[] { "None", "Normal", "Extra", "Mayhem", "Onslaught" });
            cIceTraps.Location = new Point(7, 35);
            cIceTraps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cIceTraps.Name = "cIceTraps";
            cIceTraps.Size = new Size(160, 23);
            cIceTraps.TabIndex = 26;
            cIceTraps.SelectedIndexChanged += cIceTraps_SelectedIndexChanged;
            // 
            // cIceTrapsAppearance
            // 
            cIceTrapsAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cIceTrapsAppearance.FormattingEnabled = true;
            cIceTrapsAppearance.Items.AddRange(new object[] { "Major Items", "Junk Items", "Anything" });
            cIceTrapsAppearance.Location = new Point(7, 78);
            cIceTrapsAppearance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cIceTrapsAppearance.Name = "cIceTrapsAppearance";
            cIceTrapsAppearance.Size = new Size(160, 23);
            cIceTrapsAppearance.TabIndex = 27;
            cIceTrapsAppearance.SelectedIndexChanged += cIceTrapsAppearance_SelectedIndexChanged;
            // 
            // cIceTrapQuirks
            // 
            cIceTrapQuirks.AutoSize = true;
            cIceTrapQuirks.BackColor = Color.Transparent;
            cIceTrapQuirks.ForeColor = Color.Black;
            cIceTrapQuirks.Location = new Point(7, 110);
            cIceTrapQuirks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cIceTrapQuirks.Name = "cIceTrapQuirks";
            cIceTrapQuirks.Size = new Size(98, 19);
            cIceTrapQuirks.TabIndex = 29;
            cIceTrapQuirks.Text = "Enable Quirks";
            cIceTrapQuirks.UseVisualStyleBackColor = false;
            cIceTrapQuirks.CheckedChanged += cIceTrapQuirks_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cAutoInvert);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cClockSpeed);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cHideClock);
            groupBox1.Location = new Point(574, 206);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(197, 145);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clock";
            // 
            // cAutoInvert
            // 
            cAutoInvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cAutoInvert.FormattingEnabled = true;
            cAutoInvert.Items.AddRange(new object[] { "Never", "First Cycle", "Always" });
            cAutoInvert.Location = new Point(7, 82);
            cAutoInvert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cAutoInvert.Name = "cAutoInvert";
            cAutoInvert.Size = new Size(164, 23);
            cAutoInvert.TabIndex = 18;
            cAutoInvert.SelectedIndexChanged += cAutoInvert_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 66);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 19;
            label3.Text = "Auto-invert";
            // 
            // cClockSpeed
            // 
            cClockSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cClockSpeed.FormattingEnabled = true;
            cClockSpeed.Items.AddRange(new object[] { "Default", "1/3x", "2/3x", "2x", "3x", "6x" });
            cClockSpeed.Location = new Point(7, 40);
            cClockSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cClockSpeed.Name = "cClockSpeed";
            cClockSpeed.Size = new Size(164, 23);
            cClockSpeed.TabIndex = 15;
            cClockSpeed.SelectedIndexChanged += cClockSpeed_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 24);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 16;
            label6.Text = "Speed";
            // 
            // cHideClock
            // 
            cHideClock.AutoSize = true;
            cHideClock.BackColor = Color.Transparent;
            cHideClock.ForeColor = Color.Black;
            cHideClock.Location = new Point(6, 111);
            cHideClock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cHideClock.Name = "cHideClock";
            cHideClock.Size = new Size(65, 19);
            cHideClock.TabIndex = 17;
            cHideClock.Text = "Hide UI";
            cHideClock.UseVisualStyleBackColor = false;
            cHideClock.CheckedChanged += cHideClock_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(231, 16);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(266, 60);
            label4.TabIndex = 14;
            label4.Text = "WARNING!\r\nMost of these settings are not considered in logic\r\nand some can cause the seed to be unbeatable.\r\nUse at your own risk!";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabComfort
            // 
            tabComfort.Controls.Add(gHintsGeneral);
            tabComfort.Controls.Add(gGaroHints);
            tabComfort.Controls.Add(gSpeedUps);
            tabComfort.Controls.Add(gHints);
            tabComfort.Controls.Add(groupBox8);
            tabComfort.Controls.Add(groupBox7);
            tabComfort.Location = new Point(4, 24);
            tabComfort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabComfort.Name = "tabComfort";
            tabComfort.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabComfort.Size = new Size(780, 361);
            tabComfort.TabIndex = 1;
            tabComfort.Text = "Comfort";
            tabComfort.UseVisualStyleBackColor = true;
            // 
            // gHintsGeneral
            // 
            gHintsGeneral.Controls.Add(bCustomizeHintPriorities);
            gHintsGeneral.Controls.Add(cHintImportance);
            gHintsGeneral.Controls.Add(cMixGaroWithGossip);
            gHintsGeneral.Location = new Point(7, 250);
            gHintsGeneral.Name = "gHintsGeneral";
            gHintsGeneral.Size = new Size(206, 96);
            gHintsGeneral.TabIndex = 39;
            gHintsGeneral.TabStop = false;
            gHintsGeneral.Text = "Hints";
            // 
            // bCustomizeHintPriorities
            // 
            bCustomizeHintPriorities.Location = new Point(10, 67);
            bCustomizeHintPriorities.Name = "bCustomizeHintPriorities";
            bCustomizeHintPriorities.Size = new Size(184, 23);
            bCustomizeHintPriorities.TabIndex = 16;
            bCustomizeHintPriorities.Text = "Customize Hint Priorities";
            bCustomizeHintPriorities.UseVisualStyleBackColor = true;
            bCustomizeHintPriorities.Click += bCustomizeHintPriorities_Click;
            // 
            // cHintImportance
            // 
            cHintImportance.AutoSize = true;
            cHintImportance.Location = new Point(11, 20);
            cHintImportance.Name = "cHintImportance";
            cHintImportance.Size = new Size(132, 19);
            cHintImportance.TabIndex = 0;
            cHintImportance.Text = "Indicate Importance";
            cHintImportance.UseVisualStyleBackColor = true;
            cHintImportance.CheckedChanged += cHintImportance_CheckedChanged;
            // 
            // cMixGaroWithGossip
            // 
            cMixGaroWithGossip.AutoSize = true;
            cMixGaroWithGossip.BackColor = Color.Transparent;
            cMixGaroWithGossip.ForeColor = Color.Black;
            cMixGaroWithGossip.Location = new Point(11, 45);
            cMixGaroWithGossip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cMixGaroWithGossip.Name = "cMixGaroWithGossip";
            cMixGaroWithGossip.Size = new Size(166, 19);
            cMixGaroWithGossip.TabIndex = 15;
            cMixGaroWithGossip.Text = "Mix Gossip and Garo Hints";
            cMixGaroWithGossip.UseVisualStyleBackColor = false;
            cMixGaroWithGossip.CheckedChanged += cMixGaroWithGossip_CheckedChanged;
            // 
            // gGaroHints
            // 
            gGaroHints.Controls.Add(cFreeGaroHints);
            gGaroHints.Controls.Add(cCustomGaroWoth);
            gGaroHints.Controls.Add(nMaxGaroCT);
            gGaroHints.Controls.Add(lGaroHints);
            gGaroHints.Controls.Add(nMaxGaroFoolish);
            gGaroHints.Controls.Add(cGaroHint);
            gGaroHints.Controls.Add(nMaxGaroWotH);
            gGaroHints.Controls.Add(cClearGaroHints);
            gGaroHints.Controls.Add(label5);
            gGaroHints.Controls.Add(label10);
            gGaroHints.Controls.Add(label9);
            gGaroHints.Location = new Point(221, 122);
            gGaroHints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gGaroHints.Name = "gGaroHints";
            gGaroHints.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gGaroHints.Size = new Size(207, 120);
            gGaroHints.TabIndex = 38;
            gGaroHints.TabStop = false;
            gGaroHints.Text = "Garo Hints";
            // 
            // cFreeGaroHints
            // 
            cFreeGaroHints.AutoSize = true;
            cFreeGaroHints.BackColor = Color.Transparent;
            cFreeGaroHints.ForeColor = Color.Black;
            cFreeGaroHints.Location = new Point(117, 20);
            cFreeGaroHints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cFreeGaroHints.Name = "cFreeGaroHints";
            cFreeGaroHints.Size = new Size(77, 19);
            cFreeGaroHints.TabIndex = 37;
            cFreeGaroHints.Text = "Free hints";
            cFreeGaroHints.UseVisualStyleBackColor = false;
            cFreeGaroHints.CheckedChanged += cFreeGaroHints_CheckedChanged;
            // 
            // cCustomGaroWoth
            // 
            cCustomGaroWoth.AutoSize = true;
            cCustomGaroWoth.Checked = true;
            cCustomGaroWoth.CheckState = System.Windows.Forms.CheckState.Checked;
            cCustomGaroWoth.Location = new Point(15, 88);
            cCustomGaroWoth.Name = "cCustomGaroWoth";
            cCustomGaroWoth.Size = new Size(15, 14);
            cCustomGaroWoth.TabIndex = 36;
            cCustomGaroWoth.UseVisualStyleBackColor = true;
            cCustomGaroWoth.CheckedChanged += cCustomGaroWoth_CheckedChanged;
            // 
            // nMaxGaroCT
            // 
            nMaxGaroCT.Location = new Point(160, 85);
            nMaxGaroCT.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nMaxGaroCT.Name = "nMaxGaroCT";
            nMaxGaroCT.Size = new Size(31, 23);
            nMaxGaroCT.TabIndex = 35;
            nMaxGaroCT.ValueChanged += nMaxGaroCT_ValueChanged;
            // 
            // lGaroHints
            // 
            lGaroHints.AutoSize = true;
            lGaroHints.BackColor = Color.Transparent;
            lGaroHints.ForeColor = Color.Black;
            lGaroHints.Location = new Point(13, 24);
            lGaroHints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lGaroHints.Name = "lGaroHints";
            lGaroHints.Size = new Size(95, 15);
            lGaroHints.TabIndex = 20;
            lGaroHints.Text = "Hint Distribution";
            // 
            // nMaxGaroFoolish
            // 
            nMaxGaroFoolish.Location = new Point(108, 85);
            nMaxGaroFoolish.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nMaxGaroFoolish.Name = "nMaxGaroFoolish";
            nMaxGaroFoolish.Size = new Size(31, 23);
            nMaxGaroFoolish.TabIndex = 34;
            nMaxGaroFoolish.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nMaxGaroFoolish.ValueChanged += nMaxGaroFoolish_ValueChanged;
            // 
            // cGaroHint
            // 
            cGaroHint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cGaroHint.FormattingEnabled = true;
            cGaroHint.Items.AddRange(new object[] { "Default", "Random", "Relevant", "Competitive" });
            cGaroHint.Location = new Point(15, 39);
            cGaroHint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cGaroHint.Name = "cGaroHint";
            cGaroHint.Size = new Size(92, 23);
            cGaroHint.TabIndex = 19;
            cGaroHint.SelectedIndexChanged += cGaroHint_SelectedIndexChanged;
            // 
            // nMaxGaroWotH
            // 
            nMaxGaroWotH.Location = new Point(58, 85);
            nMaxGaroWotH.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nMaxGaroWotH.Name = "nMaxGaroWotH";
            nMaxGaroWotH.Size = new Size(31, 23);
            nMaxGaroWotH.TabIndex = 33;
            nMaxGaroWotH.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nMaxGaroWotH.ValueChanged += nMaxGaroWotH_ValueChanged;
            // 
            // cClearGaroHints
            // 
            cClearGaroHints.AutoSize = true;
            cClearGaroHints.BackColor = Color.Transparent;
            cClearGaroHints.ForeColor = Color.Black;
            cClearGaroHints.Location = new Point(117, 47);
            cClearGaroHints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cClearGaroHints.Name = "cClearGaroHints";
            cClearGaroHints.Size = new Size(82, 19);
            cClearGaroHints.TabIndex = 16;
            cClearGaroHints.Text = "Clear hints";
            cClearGaroHints.UseVisualStyleBackColor = false;
            cClearGaroHints.CheckedChanged += cClearGaroHints_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 87);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 32;
            label5.Text = "/";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 70);
            label10.Name = "label10";
            label10.Size = new Size(141, 15);
            label10.TabIndex = 30;
            label10.Text = "WotH  / Foolish / Max CT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(95, 87);
            label9.Name = "label9";
            label9.Size = new Size(12, 15);
            label9.TabIndex = 31;
            label9.Text = "/";
            // 
            // gSpeedUps
            // 
            gSpeedUps.Controls.Add(cDoubleArcheryRewards);
            gSpeedUps.Controls.Add(cFasterBank);
            gSpeedUps.Controls.Add(cSkipBeaver);
            gSpeedUps.Controls.Add(cFasterLabFish);
            gSpeedUps.Controls.Add(cGoodDogRaceRNG);
            gSpeedUps.Controls.Add(cGoodDampeRNG);
            gSpeedUps.Location = new Point(7, 7);
            gSpeedUps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gSpeedUps.Name = "gSpeedUps";
            gSpeedUps.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gSpeedUps.Size = new Size(421, 109);
            gSpeedUps.TabIndex = 37;
            gSpeedUps.TabStop = false;
            gSpeedUps.Text = "Speed Ups";
            // 
            // cDoubleArcheryRewards
            // 
            cDoubleArcheryRewards.AutoSize = true;
            cDoubleArcheryRewards.Location = new Point(172, 77);
            cDoubleArcheryRewards.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cDoubleArcheryRewards.Name = "cDoubleArcheryRewards";
            cDoubleArcheryRewards.Size = new Size(155, 19);
            cDoubleArcheryRewards.TabIndex = 5;
            cDoubleArcheryRewards.Text = "Double Archery Rewards";
            cDoubleArcheryRewards.UseVisualStyleBackColor = true;
            cDoubleArcheryRewards.CheckedChanged += cDoubleArcheryRewards_CheckedChanged;
            // 
            // cFasterBank
            // 
            cFasterBank.AutoSize = true;
            cFasterBank.Location = new Point(10, 77);
            cFasterBank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cFasterBank.Name = "cFasterBank";
            cFasterBank.Size = new Size(86, 19);
            cFasterBank.TabIndex = 4;
            cFasterBank.Text = "Faster Bank";
            cFasterBank.UseVisualStyleBackColor = true;
            cFasterBank.CheckedChanged += cFasterBank_CheckedChanged;
            // 
            // cSkipBeaver
            // 
            cSkipBeaver.AutoSize = true;
            cSkipBeaver.Location = new Point(10, 24);
            cSkipBeaver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cSkipBeaver.Name = "cSkipBeaver";
            cSkipBeaver.Size = new Size(133, 19);
            cSkipBeaver.TabIndex = 0;
            cSkipBeaver.Text = "Skip Younger Beaver";
            cSkipBeaver.UseVisualStyleBackColor = true;
            cSkipBeaver.CheckedChanged += cSkipBeaver_CheckedChanged;
            // 
            // cFasterLabFish
            // 
            cFasterLabFish.AutoSize = true;
            cFasterLabFish.Location = new Point(10, 51);
            cFasterLabFish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cFasterLabFish.Name = "cFasterLabFish";
            cFasterLabFish.Size = new Size(103, 19);
            cFasterLabFish.TabIndex = 2;
            cFasterLabFish.Text = "Faster Lab Fish";
            cFasterLabFish.UseVisualStyleBackColor = true;
            cFasterLabFish.CheckedChanged += cFasterLabFish_CheckedChanged;
            // 
            // cGoodDogRaceRNG
            // 
            cGoodDogRaceRNG.AutoSize = true;
            cGoodDogRaceRNG.Location = new Point(172, 51);
            cGoodDogRaceRNG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cGoodDogRaceRNG.Name = "cGoodDogRaceRNG";
            cGoodDogRaceRNG.Size = new Size(135, 19);
            cGoodDogRaceRNG.TabIndex = 3;
            cGoodDogRaceRNG.Text = "Good Dog Race RNG";
            cGoodDogRaceRNG.UseVisualStyleBackColor = true;
            cGoodDogRaceRNG.CheckedChanged += cGoodDogRaceRNG_CheckedChanged;
            // 
            // cGoodDampeRNG
            // 
            cGoodDampeRNG.AutoSize = true;
            cGoodDampeRNG.Location = new Point(172, 23);
            cGoodDampeRNG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cGoodDampeRNG.Name = "cGoodDampeRNG";
            cGoodDampeRNG.Size = new Size(123, 19);
            cGoodDampeRNG.TabIndex = 1;
            cGoodDampeRNG.Text = "Good Dampe RNG";
            cGoodDampeRNG.UseVisualStyleBackColor = true;
            cGoodDampeRNG.CheckedChanged += cGoodDampeRNG_CheckedChanged;
            // 
            // gHints
            // 
            gHints.Controls.Add(cCustomGossipWoth);
            gHints.Controls.Add(nMaxGossipCT);
            gHints.Controls.Add(nMaxGossipFoolish);
            gHints.Controls.Add(nMaxGossipWotH);
            gHints.Controls.Add(label8);
            gHints.Controls.Add(label7);
            gHints.Controls.Add(lGossipWothConfig);
            gHints.Controls.Add(lGossip);
            gHints.Controls.Add(cGossipHints);
            gHints.Controls.Add(cFreeHints);
            gHints.Controls.Add(cClearHints);
            gHints.Location = new Point(7, 122);
            gHints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gHints.Name = "gHints";
            gHints.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gHints.Size = new Size(206, 120);
            gHints.TabIndex = 36;
            gHints.TabStop = false;
            gHints.Text = "Gossip Stone Hints";
            // 
            // cCustomGossipWoth
            // 
            cCustomGossipWoth.AutoSize = true;
            cCustomGossipWoth.Checked = true;
            cCustomGossipWoth.CheckState = System.Windows.Forms.CheckState.Checked;
            cCustomGossipWoth.Location = new Point(15, 88);
            cCustomGossipWoth.Name = "cCustomGossipWoth";
            cCustomGossipWoth.Size = new Size(15, 14);
            cCustomGossipWoth.TabIndex = 30;
            cCustomGossipWoth.UseVisualStyleBackColor = true;
            cCustomGossipWoth.CheckedChanged += cCustomGossipWoth_CheckedChanged;
            // 
            // nMaxGossipCT
            // 
            nMaxGossipCT.Location = new Point(153, 85);
            nMaxGossipCT.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nMaxGossipCT.Name = "nMaxGossipCT";
            nMaxGossipCT.Size = new Size(31, 23);
            nMaxGossipCT.TabIndex = 29;
            nMaxGossipCT.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nMaxGossipCT.ValueChanged += nMaxGossipCT_ValueChanged;
            // 
            // nMaxGossipFoolish
            // 
            nMaxGossipFoolish.Enabled = false;
            nMaxGossipFoolish.Location = new Point(101, 85);
            nMaxGossipFoolish.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nMaxGossipFoolish.Name = "nMaxGossipFoolish";
            nMaxGossipFoolish.Size = new Size(31, 23);
            nMaxGossipFoolish.TabIndex = 28;
            nMaxGossipFoolish.Value = new decimal(new int[] { 3, 0, 0, 0 });
            nMaxGossipFoolish.ValueChanged += nMaxGossipFoolish_ValueChanged;
            // 
            // nMaxGossipWotH
            // 
            nMaxGossipWotH.Enabled = false;
            nMaxGossipWotH.Location = new Point(51, 85);
            nMaxGossipWotH.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nMaxGossipWotH.Name = "nMaxGossipWotH";
            nMaxGossipWotH.Size = new Size(31, 23);
            nMaxGossipWotH.TabIndex = 27;
            nMaxGossipWotH.Value = new decimal(new int[] { 3, 0, 0, 0 });
            nMaxGossipWotH.ValueChanged += nMaxGossipWotH_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(138, 87);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 25;
            label8.Text = "/";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 87);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 23;
            label7.Text = "/";
            // 
            // lGossipWothConfig
            // 
            lGossipWothConfig.AutoSize = true;
            lGossipWothConfig.Location = new Point(51, 70);
            lGossipWothConfig.Name = "lGossipWothConfig";
            lGossipWothConfig.Size = new Size(141, 15);
            lGossipWothConfig.TabIndex = 21;
            lGossipWothConfig.Text = "WotH  / Foolish / Max CT";
            // 
            // lGossip
            // 
            lGossip.AutoSize = true;
            lGossip.BackColor = Color.Transparent;
            lGossip.ForeColor = Color.Black;
            lGossip.Location = new Point(12, 24);
            lGossip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lGossip.Name = "lGossip";
            lGossip.Size = new Size(95, 15);
            lGossip.TabIndex = 20;
            lGossip.Text = "Hint Distribution";
            // 
            // cGossipHints
            // 
            cGossipHints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cGossipHints.FormattingEnabled = true;
            cGossipHints.Items.AddRange(new object[] { "Default", "Random", "Relevant", "Competitive" });
            cGossipHints.Location = new Point(15, 39);
            cGossipHints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cGossipHints.Name = "cGossipHints";
            cGossipHints.Size = new Size(92, 23);
            cGossipHints.TabIndex = 19;
            cGossipHints.SelectedIndexChanged += cGossipHints_SelectedIndexChanged;
            // 
            // cFreeHints
            // 
            cFreeHints.AutoSize = true;
            cFreeHints.BackColor = Color.Transparent;
            cFreeHints.ForeColor = Color.Black;
            cFreeHints.Location = new Point(117, 20);
            cFreeHints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cFreeHints.Name = "cFreeHints";
            cFreeHints.Size = new Size(77, 19);
            cFreeHints.TabIndex = 15;
            cFreeHints.Text = "Free hints";
            cFreeHints.UseVisualStyleBackColor = false;
            cFreeHints.CheckedChanged += cFreeHints_CheckedChanged;
            // 
            // cClearHints
            // 
            cClearHints.AutoSize = true;
            cClearHints.BackColor = Color.Transparent;
            cClearHints.ForeColor = Color.Black;
            cClearHints.Location = new Point(117, 47);
            cClearHints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cClearHints.Name = "cClearHints";
            cClearHints.Size = new Size(82, 19);
            cClearHints.TabIndex = 16;
            cClearHints.Text = "Clear hints";
            cClearHints.UseVisualStyleBackColor = false;
            cClearHints.CheckedChanged += cClearHints_CheckedChanged;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lLink);
            groupBox8.Controls.Add(cLink);
            groupBox8.Location = new Point(221, 250);
            groupBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox8.Size = new Size(207, 96);
            groupBox8.TabIndex = 35;
            groupBox8.TabStop = false;
            groupBox8.Text = "Cosmetic Customization";
            // 
            // lLink
            // 
            lLink.AutoSize = true;
            lLink.BackColor = Color.Transparent;
            lLink.ForeColor = Color.Black;
            lLink.Location = new Point(4, 23);
            lLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lLink.Name = "lLink";
            lLink.Size = new Size(76, 15);
            lLink.TabIndex = 9;
            lLink.Text = "Player model";
            // 
            // cLink
            // 
            cLink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cLink.FormattingEnabled = true;
            cLink.Items.AddRange(new object[] { "Link (MM)", "Link (OoT)", "Adult Link (Risky!)", "Kafei" });
            cLink.Location = new Point(7, 38);
            cLink.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cLink.Name = "cLink";
            cLink.Size = new Size(129, 23);
            cLink.TabIndex = 10;
            cLink.SelectedIndexChanged += cLink_SelectedIndexChanged;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cInvisSparkle);
            groupBox7.Controls.Add(cFillWallet);
            groupBox7.Controls.Add(cTargetHealth);
            groupBox7.Controls.Add(cLenientGoronSpikes);
            groupBox7.Controls.Add(cImprovedPictobox);
            groupBox7.Controls.Add(cElegySpeedups);
            groupBox7.Controls.Add(cCloseCows);
            groupBox7.Controls.Add(cArrowCycling);
            groupBox7.Controls.Add(cFreestanding);
            groupBox7.Controls.Add(cFastPush);
            groupBox7.Controls.Add(cQText);
            groupBox7.Controls.Add(cShopAppearance);
            groupBox7.Controls.Add(cEponaSword);
            groupBox7.Controls.Add(cUpdateChests);
            groupBox7.Controls.Add(cDisableCritWiggle);
            groupBox7.Controls.Add(cQuestItemStorage);
            groupBox7.Controls.Add(cNoDowngrades);
            groupBox7.Location = new Point(435, 7);
            groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox7.Size = new Size(334, 339);
            groupBox7.TabIndex = 34;
            groupBox7.TabStop = false;
            groupBox7.Text = "Comfort Options";
            // 
            // cInvisSparkle
            // 
            cInvisSparkle.AutoSize = true;
            cInvisSparkle.Location = new Point(10, 233);
            cInvisSparkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cInvisSparkle.Name = "cInvisSparkle";
            cInvisSparkle.Size = new Size(147, 19);
            cInvisSparkle.TabIndex = 42;
            cInvisSparkle.Text = "Hidden Rupees Sparkle";
            cInvisSparkle.UseVisualStyleBackColor = true;
            cInvisSparkle.CheckedChanged += cInvisSparkle_CheckedChanged;
            // 
            // cFillWallet
            // 
            cFillWallet.AutoSize = true;
            cFillWallet.Location = new Point(10, 207);
            cFillWallet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cFillWallet.Name = "cFillWallet";
            cFillWallet.Size = new Size(139, 19);
            cFillWallet.TabIndex = 41;
            cFillWallet.Text = "Fill wallet on upgrade";
            cFillWallet.UseVisualStyleBackColor = true;
            cFillWallet.CheckedChanged += cFillWallet_CheckedChanged;
            // 
            // cTargetHealth
            // 
            cTargetHealth.AutoSize = true;
            cTargetHealth.Location = new Point(10, 181);
            cTargetHealth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cTargetHealth.Name = "cTargetHealth";
            cTargetHealth.Size = new Size(116, 19);
            cTargetHealth.TabIndex = 40;
            cTargetHealth.Text = "Target Health Bar";
            cTargetHealth.UseVisualStyleBackColor = true;
            cTargetHealth.CheckedChanged += cTargetHealth_CheckedChanged;
            // 
            // cLenientGoronSpikes
            // 
            cLenientGoronSpikes.AutoSize = true;
            cLenientGoronSpikes.Location = new Point(10, 155);
            cLenientGoronSpikes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cLenientGoronSpikes.Name = "cLenientGoronSpikes";
            cLenientGoronSpikes.Size = new Size(137, 19);
            cLenientGoronSpikes.TabIndex = 39;
            cLenientGoronSpikes.Text = "Lenient Goron Spikes";
            cLenientGoronSpikes.UseVisualStyleBackColor = true;
            cLenientGoronSpikes.CheckedChanged += cLenientGoronSpikes_CheckedChanged;
            // 
            // cImprovedPictobox
            // 
            cImprovedPictobox.AutoSize = true;
            cImprovedPictobox.Location = new Point(10, 129);
            cImprovedPictobox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cImprovedPictobox.Name = "cImprovedPictobox";
            cImprovedPictobox.Size = new Size(127, 19);
            cImprovedPictobox.TabIndex = 38;
            cImprovedPictobox.Text = "Improved Pictobox";
            cImprovedPictobox.UseVisualStyleBackColor = true;
            cImprovedPictobox.CheckedChanged += cImprovedPictobox_CheckedChanged;
            // 
            // cElegySpeedups
            // 
            cElegySpeedups.AutoSize = true;
            cElegySpeedups.Location = new Point(172, 207);
            cElegySpeedups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cElegySpeedups.Name = "cElegySpeedups";
            cElegySpeedups.Size = new Size(107, 19);
            cElegySpeedups.TabIndex = 37;
            cElegySpeedups.Text = "Elegy speedups";
            cElegySpeedups.UseVisualStyleBackColor = true;
            cElegySpeedups.CheckedChanged += cElegySpeedups_CheckedChanged;
            // 
            // cCloseCows
            // 
            cCloseCows.AutoSize = true;
            cCloseCows.Location = new Point(10, 103);
            cCloseCows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cCloseCows.Name = "cCloseCows";
            cCloseCows.Size = new Size(87, 19);
            cCloseCows.TabIndex = 36;
            cCloseCows.Text = "Close Cows";
            cCloseCows.UseVisualStyleBackColor = true;
            cCloseCows.CheckedChanged += cCloseCows_CheckedChanged;
            // 
            // cArrowCycling
            // 
            cArrowCycling.AutoSize = true;
            cArrowCycling.Location = new Point(172, 181);
            cArrowCycling.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cArrowCycling.Name = "cArrowCycling";
            cArrowCycling.Size = new Size(99, 19);
            cArrowCycling.TabIndex = 35;
            cArrowCycling.Text = "Arrow cycling";
            cArrowCycling.UseVisualStyleBackColor = true;
            cArrowCycling.CheckedChanged += cArrowCycling_CheckedChanged;
            // 
            // cFreestanding
            // 
            cFreestanding.AutoSize = true;
            cFreestanding.Location = new Point(172, 77);
            cFreestanding.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cFreestanding.Name = "cFreestanding";
            cFreestanding.Size = new Size(139, 19);
            cFreestanding.TabIndex = 34;
            cFreestanding.Text = "Update world models";
            cFreestanding.UseVisualStyleBackColor = true;
            cFreestanding.CheckedChanged += cFreestanding_CheckedChanged;
            // 
            // cFastPush
            // 
            cFastPush.AutoSize = true;
            cFastPush.Location = new Point(10, 77);
            cFastPush.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cFastPush.Name = "cFastPush";
            cFastPush.Size = new Size(132, 19);
            cFastPush.TabIndex = 31;
            cFastPush.Text = "Increase push speed";
            cFastPush.UseVisualStyleBackColor = true;
            cFastPush.CheckedChanged += cFastPush_CheckedChanged;
            // 
            // cQText
            // 
            cQText.AutoSize = true;
            cQText.BackColor = Color.Transparent;
            cQText.ForeColor = Color.Black;
            cQText.Location = new Point(10, 51);
            cQText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cQText.Name = "cQText";
            cQText.Size = new Size(80, 19);
            cQText.TabIndex = 6;
            cQText.Text = "Quick text";
            cQText.UseVisualStyleBackColor = false;
            cQText.CheckedChanged += cQText_CheckedChanged;
            // 
            // cShopAppearance
            // 
            cShopAppearance.AutoSize = true;
            cShopAppearance.BackColor = Color.Transparent;
            cShopAppearance.ForeColor = Color.Black;
            cShopAppearance.Location = new Point(172, 25);
            cShopAppearance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cShopAppearance.Name = "cShopAppearance";
            cShopAppearance.Size = new Size(98, 19);
            cShopAppearance.TabIndex = 21;
            cShopAppearance.Text = "Update shops";
            cShopAppearance.UseVisualStyleBackColor = false;
            cShopAppearance.CheckedChanged += cShopAppearance_CheckedChanged;
            // 
            // cEponaSword
            // 
            cEponaSword.AutoSize = true;
            cEponaSword.BackColor = Color.Transparent;
            cEponaSword.ForeColor = Color.Black;
            cEponaSword.Location = new Point(172, 129);
            cEponaSword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cEponaSword.Name = "cEponaSword";
            cEponaSword.Size = new Size(112, 19);
            cEponaSword.TabIndex = 22;
            cEponaSword.Text = "Fix Epona sword";
            cEponaSword.UseVisualStyleBackColor = false;
            cEponaSword.CheckedChanged += cEponaSword_CheckedChanged;
            // 
            // cUpdateChests
            // 
            cUpdateChests.AutoSize = true;
            cUpdateChests.BackColor = Color.Transparent;
            cUpdateChests.ForeColor = Color.Black;
            cUpdateChests.Location = new Point(172, 51);
            cUpdateChests.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cUpdateChests.Name = "cUpdateChests";
            cUpdateChests.Size = new Size(100, 19);
            cUpdateChests.TabIndex = 23;
            cUpdateChests.Text = "Update chests";
            cUpdateChests.UseVisualStyleBackColor = false;
            cUpdateChests.CheckedChanged += cUpdateChests_CheckedChanged;
            // 
            // cDisableCritWiggle
            // 
            cDisableCritWiggle.AutoSize = true;
            cDisableCritWiggle.BackColor = Color.Transparent;
            cDisableCritWiggle.Location = new Point(10, 25);
            cDisableCritWiggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cDisableCritWiggle.Name = "cDisableCritWiggle";
            cDisableCritWiggle.Size = new Size(122, 19);
            cDisableCritWiggle.TabIndex = 29;
            cDisableCritWiggle.Text = "Disable crit wiggle";
            cDisableCritWiggle.UseVisualStyleBackColor = false;
            cDisableCritWiggle.CheckedChanged += cDisableCritWiggle_CheckedChanged;
            // 
            // cQuestItemStorage
            // 
            cQuestItemStorage.AutoSize = true;
            cQuestItemStorage.BackColor = Color.Transparent;
            cQuestItemStorage.Location = new Point(172, 155);
            cQuestItemStorage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cQuestItemStorage.Name = "cQuestItemStorage";
            cQuestItemStorage.Size = new Size(155, 19);
            cQuestItemStorage.TabIndex = 30;
            cQuestItemStorage.Text = "Quest item extra storage";
            cQuestItemStorage.UseVisualStyleBackColor = false;
            cQuestItemStorage.CheckedChanged += cQuestItemStorage_CheckedChanged;
            // 
            // cNoDowngrades
            // 
            cNoDowngrades.AutoSize = true;
            cNoDowngrades.BackColor = Color.Transparent;
            cNoDowngrades.ForeColor = Color.Black;
            cNoDowngrades.Location = new Point(172, 103);
            cNoDowngrades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cNoDowngrades.Name = "cNoDowngrades";
            cNoDowngrades.Size = new Size(110, 19);
            cNoDowngrades.TabIndex = 18;
            cNoDowngrades.Text = "No downgrades";
            cNoDowngrades.UseVisualStyleBackColor = false;
            cNoDowngrades.CheckedChanged += cNoDowngrades_CheckedChanged;
            // 
            // tabShortenCutscenes
            // 
            tabShortenCutscenes.Controls.Add(tShortenCutscenes);
            tabShortenCutscenes.Location = new Point(4, 24);
            tabShortenCutscenes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabShortenCutscenes.Name = "tabShortenCutscenes";
            tabShortenCutscenes.Size = new Size(780, 361);
            tabShortenCutscenes.TabIndex = 5;
            tabShortenCutscenes.Text = "Shorten Cutscenes";
            tabShortenCutscenes.UseVisualStyleBackColor = true;
            // 
            // tShortenCutscenes
            // 
            tShortenCutscenes.Location = new Point(8, 5);
            tShortenCutscenes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tShortenCutscenes.Name = "tShortenCutscenes";
            tShortenCutscenes.SelectedIndex = 0;
            tShortenCutscenes.Size = new Size(758, 322);
            tShortenCutscenes.TabIndex = 0;
            // 
            // tabCosmetics
            // 
            tabCosmetics.Controls.Add(gCosmeticOther);
            tabCosmetics.Controls.Add(gCosmeticMusicSound);
            tabCosmetics.Controls.Add(cHUDGroupBox);
            tabCosmetics.Controls.Add(tFormCosmetics);
            tabCosmetics.Location = new Point(4, 24);
            tabCosmetics.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabCosmetics.Name = "tabCosmetics";
            tabCosmetics.Size = new Size(780, 361);
            tabCosmetics.TabIndex = 4;
            tabCosmetics.Text = "Cosmetics";
            tabCosmetics.UseVisualStyleBackColor = true;
            // 
            // gCosmeticOther
            // 
            gCosmeticOther.Controls.Add(cInstantPictobox);
            gCosmeticOther.Controls.Add(cTatl);
            gCosmeticOther.Controls.Add(lTatl);
            gCosmeticOther.Controls.Add(cTargettingStyle);
            gCosmeticOther.Location = new Point(299, 3);
            gCosmeticOther.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gCosmeticOther.Name = "gCosmeticOther";
            gCosmeticOther.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gCosmeticOther.Size = new Size(468, 149);
            gCosmeticOther.TabIndex = 47;
            gCosmeticOther.TabStop = false;
            gCosmeticOther.Text = "Other";
            // 
            // cInstantPictobox
            // 
            cInstantPictobox.AutoSize = true;
            cInstantPictobox.BackColor = Color.Transparent;
            cInstantPictobox.Location = new Point(10, 90);
            cInstantPictobox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cInstantPictobox.Name = "cInstantPictobox";
            cInstantPictobox.Size = new Size(180, 19);
            cInstantPictobox.TabIndex = 42;
            cInstantPictobox.Text = "Instant Pictobox on Emulator";
            cInstantPictobox.UseVisualStyleBackColor = false;
            cInstantPictobox.CheckedChanged += cInstantPictobox_CheckedChanged;
            // 
            // cTatl
            // 
            cTatl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cTatl.FormattingEnabled = true;
            cTatl.Items.AddRange(new object[] { "Default", "Dark", "Hot", "Cool", "Random", "Rainbow (cycle)" });
            cTatl.Location = new Point(10, 33);
            cTatl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cTatl.Name = "cTatl";
            cTatl.Size = new Size(150, 23);
            cTatl.TabIndex = 41;
            cTatl.SelectedIndexChanged += cTatl_SelectedIndexChanged;
            // 
            // lTatl
            // 
            lTatl.AutoSize = true;
            lTatl.BackColor = Color.Transparent;
            lTatl.ForeColor = Color.Black;
            lTatl.Location = new Point(7, 18);
            lTatl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lTatl.Name = "lTatl";
            lTatl.Size = new Size(62, 15);
            lTatl.TabIndex = 40;
            lTatl.Text = "Tatl theme";
            // 
            // cTargettingStyle
            // 
            cTargettingStyle.AutoSize = true;
            cTargettingStyle.BackColor = Color.Transparent;
            cTargettingStyle.Location = new Point(10, 65);
            cTargettingStyle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cTargettingStyle.Name = "cTargettingStyle";
            cTargettingStyle.Size = new Size(140, 19);
            cTargettingStyle.TabIndex = 37;
            cTargettingStyle.Text = "Default Hold Z-Target";
            cTargettingStyle.UseVisualStyleBackColor = false;
            cTargettingStyle.CheckedChanged += cTargettingStyle_CheckedChanged;
            // 
            // gCosmeticMusicSound
            // 
            gCosmeticMusicSound.Controls.Add(lLuckRoll);
            gCosmeticMusicSound.Controls.Add(tLuckRollPercentage);
            gCosmeticMusicSound.Controls.Add(lMusic);
            gCosmeticMusicSound.Controls.Add(cMusic);
            gCosmeticMusicSound.Controls.Add(cSFX);
            gCosmeticMusicSound.Controls.Add(cCombatMusicDisable);
            gCosmeticMusicSound.Controls.Add(cEnableNightMusic);
            gCosmeticMusicSound.Controls.Add(cLowHealthSFXComboBox);
            gCosmeticMusicSound.Controls.Add(lLowHealthSFXComboBox);
            gCosmeticMusicSound.Location = new Point(8, 159);
            gCosmeticMusicSound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gCosmeticMusicSound.Name = "gCosmeticMusicSound";
            gCosmeticMusicSound.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gCosmeticMusicSound.Size = new Size(284, 195);
            gCosmeticMusicSound.TabIndex = 46;
            gCosmeticMusicSound.TabStop = false;
            gCosmeticMusicSound.Text = "Music / Sound";
            // 
            // lLuckRoll
            // 
            lLuckRoll.AutoSize = true;
            lLuckRoll.BackColor = Color.Transparent;
            lLuckRoll.ForeColor = Color.Black;
            lLuckRoll.Location = new Point(154, 99);
            lLuckRoll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lLuckRoll.Name = "lLuckRoll";
            lLuckRoll.Size = new Size(119, 15);
            lLuckRoll.TabIndex = 47;
            lLuckRoll.Text = "Luck Roll Chance (%)";
            // 
            // tLuckRollPercentage
            // 
            tLuckRollPercentage.DecimalPlaces = 2;
            tLuckRollPercentage.Location = new Point(154, 114);
            tLuckRollPercentage.Name = "tLuckRollPercentage";
            tLuckRollPercentage.Size = new Size(117, 23);
            tLuckRollPercentage.TabIndex = 46;
            tLuckRollPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            tLuckRollPercentage.Value = new decimal(new int[] { 333, 0, 0, 131072 });
            tLuckRollPercentage.ValueChanged += tLuckRollPercentage_ValueChanged;
            // 
            // lMusic
            // 
            lMusic.AutoSize = true;
            lMusic.BackColor = Color.Transparent;
            lMusic.ForeColor = Color.Black;
            lMusic.Location = new Point(4, 99);
            lMusic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lMusic.Name = "lMusic";
            lMusic.Size = new Size(39, 15);
            lMusic.TabIndex = 43;
            lMusic.Text = "Music";
            // 
            // cMusic
            // 
            cMusic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cMusic.FormattingEnabled = true;
            cMusic.Items.AddRange(new object[] { "Default", "Random", "None" });
            cMusic.Location = new Point(7, 114);
            cMusic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cMusic.Name = "cMusic";
            cMusic.Size = new Size(140, 23);
            cMusic.TabIndex = 42;
            cMusic.SelectedIndexChanged += cMusic_SelectedIndexChanged;
            // 
            // cSFX
            // 
            cSFX.AutoSize = true;
            cSFX.BackColor = Color.Transparent;
            cSFX.ForeColor = Color.Black;
            cSFX.Location = new Point(7, 23);
            cSFX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cSFX.Name = "cSFX";
            cSFX.Size = new Size(107, 19);
            cSFX.TabIndex = 36;
            cSFX.Text = "Randomize SFX";
            cSFX.UseVisualStyleBackColor = false;
            cSFX.CheckedChanged += cSFX_CheckedChanged;
            // 
            // cCombatMusicDisable
            // 
            cCombatMusicDisable.AutoSize = true;
            cCombatMusicDisable.Location = new Point(7, 76);
            cCombatMusicDisable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cCombatMusicDisable.Name = "cCombatMusicDisable";
            cCombatMusicDisable.Size = new Size(145, 19);
            cCombatMusicDisable.TabIndex = 45;
            cCombatMusicDisable.Text = "Disable Combat Music";
            cCombatMusicDisable.UseVisualStyleBackColor = true;
            cCombatMusicDisable.CheckedChanged += cCombatMusicDisable_CheckedChanged;
            // 
            // cEnableNightMusic
            // 
            cEnableNightMusic.AutoSize = true;
            cEnableNightMusic.Location = new Point(7, 50);
            cEnableNightMusic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cEnableNightMusic.Name = "cEnableNightMusic";
            cEnableNightMusic.Size = new Size(123, 19);
            cEnableNightMusic.TabIndex = 38;
            cEnableNightMusic.Text = "Enable Night BGM";
            cEnableNightMusic.UseVisualStyleBackColor = true;
            cEnableNightMusic.CheckedChanged += cEnableNightMusic_CheckedChanged;
            // 
            // cLowHealthSFXComboBox
            // 
            cLowHealthSFXComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cLowHealthSFXComboBox.FormattingEnabled = true;
            cLowHealthSFXComboBox.Location = new Point(7, 163);
            cLowHealthSFXComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cLowHealthSFXComboBox.Name = "cLowHealthSFXComboBox";
            cLowHealthSFXComboBox.Size = new Size(140, 23);
            cLowHealthSFXComboBox.TabIndex = 25;
            cLowHealthSFXComboBox.SelectedIndexChanged += cLowHealthSFXComboBox_SelectedIndexChanged;
            // 
            // lLowHealthSFXComboBox
            // 
            lLowHealthSFXComboBox.AutoSize = true;
            lLowHealthSFXComboBox.Location = new Point(4, 142);
            lLowHealthSFXComboBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lLowHealthSFXComboBox.Name = "lLowHealthSFXComboBox";
            lLowHealthSFXComboBox.Size = new Size(89, 15);
            lLowHealthSFXComboBox.TabIndex = 25;
            lLowHealthSFXComboBox.Text = "Low Health SFX";
            // 
            // cHUDGroupBox
            // 
            cHUDGroupBox.Controls.Add(cHueShiftMiscUI);
            cHUDGroupBox.Controls.Add(cHUDTableLayoutPanel);
            cHUDGroupBox.Location = new Point(299, 159);
            cHUDGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cHUDGroupBox.Name = "cHUDGroupBox";
            cHUDGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cHUDGroupBox.Size = new Size(468, 195);
            cHUDGroupBox.TabIndex = 44;
            cHUDGroupBox.TabStop = false;
            cHUDGroupBox.Text = "HUD";
            // 
            // cHueShiftMiscUI
            // 
            cHueShiftMiscUI.AutoSize = true;
            cHueShiftMiscUI.Location = new Point(10, 91);
            cHueShiftMiscUI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cHueShiftMiscUI.Name = "cHueShiftMiscUI";
            cHueShiftMiscUI.Size = new Size(216, 19);
            cHueShiftMiscUI.TabIndex = 1;
            cHueShiftMiscUI.Text = "Randomize Hue of Miscellaneous UI";
            cHueShiftMiscUI.UseVisualStyleBackColor = true;
            cHueShiftMiscUI.CheckedChanged += cHueShiftMiscUI_CheckedChanged;
            // 
            // cHUDTableLayoutPanel
            // 
            cHUDTableLayoutPanel.ColumnCount = 3;
            cHUDTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            cHUDTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            cHUDTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            cHUDTableLayoutPanel.Controls.Add(cHUDHeartsComboBox, 1, 0);
            cHUDTableLayoutPanel.Controls.Add(cHeartsLabel, 0, 0);
            cHUDTableLayoutPanel.Controls.Add(cMagicLabel, 0, 1);
            cHUDTableLayoutPanel.Controls.Add(cHUDMagicComboBox, 1, 1);
            cHUDTableLayoutPanel.Controls.Add(btn_hud, 2, 0);
            cHUDTableLayoutPanel.Location = new Point(2, 18);
            cHUDTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cHUDTableLayoutPanel.Name = "cHUDTableLayoutPanel";
            cHUDTableLayoutPanel.RowCount = 2;
            cHUDTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            cHUDTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            cHUDTableLayoutPanel.Size = new Size(458, 66);
            cHUDTableLayoutPanel.TabIndex = 0;
            // 
            // cHUDHeartsComboBox
            // 
            cHUDHeartsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            cHUDHeartsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cHUDHeartsComboBox.FormattingEnabled = true;
            cHUDHeartsComboBox.Location = new Point(62, 3);
            cHUDHeartsComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cHUDHeartsComboBox.Name = "cHUDHeartsComboBox";
            cHUDHeartsComboBox.Size = new Size(301, 23);
            cHUDHeartsComboBox.TabIndex = 32;
            cHUDHeartsComboBox.SelectedIndexChanged += cHUDHeartsComboBox_SelectedIndexChanged;
            // 
            // cHeartsLabel
            // 
            cHeartsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cHeartsLabel.AutoSize = true;
            cHeartsLabel.Location = new Point(4, 9);
            cHeartsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cHeartsLabel.Name = "cHeartsLabel";
            cHeartsLabel.Size = new Size(44, 15);
            cHeartsLabel.TabIndex = 33;
            cHeartsLabel.Text = "Hearts:";
            // 
            // cMagicLabel
            // 
            cMagicLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cMagicLabel.AutoSize = true;
            cMagicLabel.Location = new Point(4, 42);
            cMagicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cMagicLabel.Name = "cMagicLabel";
            cMagicLabel.Size = new Size(43, 15);
            cMagicLabel.TabIndex = 34;
            cMagicLabel.Text = "Magic:";
            // 
            // cHUDMagicComboBox
            // 
            cHUDMagicComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            cHUDMagicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cHUDMagicComboBox.FormattingEnabled = true;
            cHUDMagicComboBox.Location = new Point(62, 36);
            cHUDMagicComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cHUDMagicComboBox.Name = "cHUDMagicComboBox";
            cHUDMagicComboBox.Size = new Size(301, 23);
            cHUDMagicComboBox.TabIndex = 35;
            cHUDMagicComboBox.SelectedIndexChanged += cHUDMagicComboBox_SelectedIndexChanged;
            // 
            // btn_hud
            // 
            btn_hud.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_hud.AutoSize = true;
            btn_hud.Location = new Point(371, 11);
            btn_hud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_hud.Name = "btn_hud";
            cHUDTableLayoutPanel.SetRowSpan(btn_hud, 2);
            btn_hud.Size = new Size(83, 43);
            btn_hud.TabIndex = 31;
            btn_hud.Text = "Customize";
            btn_hud.UseVisualStyleBackColor = true;
            btn_hud.Click += btn_hud_Click;
            // 
            // tFormCosmetics
            // 
            tFormCosmetics.Location = new Point(7, 3);
            tFormCosmetics.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tFormCosmetics.Name = "tFormCosmetics";
            tFormCosmetics.SelectedIndex = 0;
            tFormCosmetics.Size = new Size(285, 149);
            tFormCosmetics.TabIndex = 39;
            // 
            // cDrawHash
            // 
            cDrawHash.AutoSize = true;
            cDrawHash.BackColor = Color.Transparent;
            cDrawHash.ForeColor = SystemColors.ControlText;
            cDrawHash.Location = new Point(132, 74);
            cDrawHash.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cDrawHash.Name = "cDrawHash";
            cDrawHash.Size = new Size(111, 19);
            cDrawHash.TabIndex = 28;
            cDrawHash.Text = "Hash Icons .png";
            cDrawHash.UseVisualStyleBackColor = false;
            cDrawHash.CheckedChanged += cDrawHash_CheckedChanged;
            // 
            // gGameOutput
            // 
            gGameOutput.Controls.Add(cHTMLLog);
            gGameOutput.Controls.Add(cPatch);
            gGameOutput.Controls.Add(cDrawHash);
            gGameOutput.Controls.Add(cSpoiler);
            gGameOutput.Controls.Add(cN64);
            gGameOutput.Controls.Add(cVC);
            gGameOutput.Location = new Point(15, 468);
            gGameOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gGameOutput.Name = "gGameOutput";
            gGameOutput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gGameOutput.Size = new Size(264, 103);
            gGameOutput.TabIndex = 16;
            gGameOutput.TabStop = false;
            gGameOutput.Text = "Outputs";
            // 
            // cHTMLLog
            // 
            cHTMLLog.AutoSize = true;
            cHTMLLog.BackColor = Color.Transparent;
            cHTMLLog.Checked = true;
            cHTMLLog.CheckState = System.Windows.Forms.CheckState.Checked;
            cHTMLLog.ForeColor = Color.Black;
            cHTMLLog.Location = new Point(132, 48);
            cHTMLLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cHTMLLog.Name = "cHTMLLog";
            cHTMLLog.Size = new Size(121, 19);
            cHTMLLog.TabIndex = 14;
            cHTMLLog.Text = "Item Tracker .html";
            cHTMLLog.UseVisualStyleBackColor = false;
            cHTMLLog.CheckedChanged += cHTMLLog_CheckedChanged;
            // 
            // cPatch
            // 
            cPatch.AutoSize = true;
            cPatch.BackColor = Color.Transparent;
            cPatch.ForeColor = Color.Black;
            cPatch.Location = new Point(19, 74);
            cPatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cPatch.Name = "cPatch";
            cPatch.Size = new Size(88, 19);
            cPatch.TabIndex = 15;
            cPatch.Text = "Patch .mmr";
            cPatch.UseVisualStyleBackColor = false;
            cPatch.CheckedChanged += cPatch_CheckedChanged;
            // 
            // cSpoiler
            // 
            cSpoiler.AutoSize = true;
            cSpoiler.BackColor = Color.Transparent;
            cSpoiler.Checked = true;
            cSpoiler.CheckState = System.Windows.Forms.CheckState.Checked;
            cSpoiler.ForeColor = Color.Black;
            cSpoiler.Location = new Point(132, 22);
            cSpoiler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cSpoiler.Name = "cSpoiler";
            cSpoiler.Size = new Size(102, 19);
            cSpoiler.TabIndex = 8;
            cSpoiler.Text = "Spoiler log .txt";
            cSpoiler.UseVisualStyleBackColor = false;
            cSpoiler.CheckedChanged += cSpoiler_CheckedChanged;
            // 
            // cN64
            // 
            cN64.AutoSize = true;
            cN64.BackColor = Color.Transparent;
            cN64.Checked = true;
            cN64.CheckState = System.Windows.Forms.CheckState.Checked;
            cN64.ForeColor = Color.Black;
            cN64.Location = new Point(19, 21);
            cN64.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cN64.Name = "cN64";
            cN64.Size = new Size(100, 19);
            cN64.TabIndex = 10;
            cN64.Text = "N64 ROM .z64";
            cN64.UseVisualStyleBackColor = false;
            cN64.CheckedChanged += cN64_CheckedChanged;
            // 
            // cVC
            // 
            cVC.AutoSize = true;
            cVC.BackColor = Color.Transparent;
            cVC.ForeColor = Color.Black;
            cVC.Location = new Point(19, 47);
            cVC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cVC.Name = "cVC";
            cVC.Size = new Size(89, 19);
            cVC.TabIndex = 9;
            cVC.Text = "Wii VC .wad";
            cVC.UseVisualStyleBackColor = false;
            cVC.CheckedChanged += cVC_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 420);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 15);
            label1.TabIndex = 12;
            label1.Text = "ROM must be Majora's Mask (U) ending with \".z64\"";
            // 
            // bApplyPatch
            // 
            bApplyPatch.Location = new Point(357, 10);
            bApplyPatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bApplyPatch.Name = "bApplyPatch";
            bApplyPatch.Size = new Size(115, 54);
            bApplyPatch.TabIndex = 16;
            bApplyPatch.Text = "Apply Patch";
            bApplyPatch.UseVisualStyleBackColor = true;
            bApplyPatch.Click += bApplyPatch_Click;
            // 
            // saveROM
            // 
            saveROM.DefaultExt = "z64";
            saveROM.Filter = "ROM files|*.z64";
            // 
            // cTunic
            // 
            cTunic.Color = Color.FromArgb(30, 105, 27);
            // 
            // bRandomise
            // 
            bRandomise.Location = new Point(357, 10);
            bRandomise.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bRandomise.Name = "bRandomise";
            bRandomise.Size = new Size(115, 54);
            bRandomise.TabIndex = 5;
            bRandomise.Text = "Randomize";
            bRandomise.UseVisualStyleBackColor = true;
            bRandomise.Click += bRandomise_Click;
            // 
            // saveWad
            // 
            saveWad.DefaultExt = "wad";
            saveWad.Filter = "VC files|*.wad";
            // 
            // mMenu
            // 
            mMenu.BackColor = SystemColors.Control;
            mMenu.ImageScalingSize = new Size(20, 20);
            mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mFile, mCustomise, toolsToolStripMenuItem, mHelp });
            mMenu.Location = new Point(0, 0);
            mMenu.Name = "mMenu";
            mMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            mMenu.Size = new Size(792, 24);
            mMenu.TabIndex = 12;
            mMenu.Text = "mMenu";
            // 
            // mFile
            // 
            mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saveSettingsToolStripMenuItem, loadSettingsToolStripMenuItem, mExit });
            mFile.Name = "mFile";
            mFile.Size = new Size(37, 20);
            mFile.Text = "File";
            // 
            // saveSettingsToolStripMenuItem
            // 
            saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            saveSettingsToolStripMenuItem.Size = new Size(154, 22);
            saveSettingsToolStripMenuItem.Text = "Save Settings...";
            saveSettingsToolStripMenuItem.Click += SaveSettingsToolStripMenuItem_Click;
            // 
            // loadSettingsToolStripMenuItem
            // 
            loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            loadSettingsToolStripMenuItem.Size = new Size(154, 22);
            loadSettingsToolStripMenuItem.Text = "Load Settings...";
            loadSettingsToolStripMenuItem.Click += LoadSettingsToolStripMenuItem_Click;
            // 
            // mExit
            // 
            mExit.Name = "mExit";
            mExit.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            mExit.Size = new Size(154, 22);
            mExit.Text = "Exit";
            mExit.Click += mExit_Click;
            // 
            // mCustomise
            // 
            mCustomise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mDPadConfig });
            mCustomise.Name = "mCustomise";
            mCustomise.Size = new Size(75, 20);
            mCustomise.Text = "Customize";
            // 
            // mDPadConfig
            // 
            mDPadConfig.Name = "mDPadConfig";
            mDPadConfig.Size = new Size(184, 22);
            mDPadConfig.Text = "D-Pad Configuration";
            mDPadConfig.Click += mDPadConfig_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mLogicEdit });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // mLogicEdit
            // 
            mLogicEdit.Name = "mLogicEdit";
            mLogicEdit.Size = new Size(137, 22);
            mLogicEdit.Text = "Logic editor";
            mLogicEdit.Click += mLogicEdit_Click;
            // 
            // mHelp
            // 
            mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mManual, mSep1, mAbout });
            mHelp.Name = "mHelp";
            mHelp.Size = new Size(44, 20);
            mHelp.Text = "Help";
            // 
            // mManual
            // 
            mManual.Name = "mManual";
            mManual.ShortcutKeys = System.Windows.Forms.Keys.F1;
            mManual.Size = new Size(133, 22);
            mManual.Text = "Manual";
            mManual.Click += mManual_Click;
            // 
            // mSep1
            // 
            mSep1.Name = "mSep1";
            mSep1.Size = new Size(130, 6);
            // 
            // mAbout
            // 
            mAbout.Name = "mAbout";
            mAbout.Size = new Size(133, 22);
            mAbout.Text = "About";
            mAbout.Click += mAbout_Click;
            // 
            // openBROM
            // 
            openBROM.Filter = "ROM files|*.z64;*.v64;*.n64";
            // 
            // pProgress
            // 
            pProgress.Location = new Point(15, 592);
            pProgress.Margin = new System.Windows.Forms.Padding(2);
            pProgress.Name = "pProgress";
            pProgress.Size = new Size(762, 22);
            pProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            pProgress.TabIndex = 13;
            // 
            // bgWorker
            // 
            bgWorker.WorkerReportsProgress = true;
            // 
            // lStatus
            // 
            lStatus.AutoSize = true;
            lStatus.BackColor = Color.Transparent;
            lStatus.Location = new Point(13, 573);
            lStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lStatus.Name = "lStatus";
            lStatus.Size = new Size(48, 15);
            lStatus.TabIndex = 13;
            lStatus.Text = "Ready...";
            // 
            // tSeed
            // 
            tSeed.Location = new Point(90, 12);
            tSeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tSeed.MaxLength = 10;
            tSeed.Name = "tSeed";
            tSeed.Size = new Size(259, 23);
            tSeed.TabIndex = 2;
            tSeed.Enter += tSeed_Enter;
            tSeed.KeyDown += tSeed_KeyDown;
            tSeed.Leave += tSeed_Leave;
            // 
            // lSeed
            // 
            lSeed.AutoSize = true;
            lSeed.BackColor = Color.Transparent;
            lSeed.ForeColor = Color.Black;
            lSeed.Location = new Point(1, 15);
            lSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lSeed.Name = "lSeed";
            lSeed.Size = new Size(82, 15);
            lSeed.TabIndex = 3;
            lSeed.Text = "Random seed:";
            // 
            // cDummy
            // 
            cDummy.AutoSize = true;
            cDummy.Enabled = false;
            cDummy.Location = new Point(684, 582);
            cDummy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cDummy.Name = "cDummy";
            cDummy.Size = new Size(83, 19);
            cDummy.TabIndex = 9;
            cDummy.Text = "checkBox1";
            cDummy.UseVisualStyleBackColor = true;
            cDummy.Visible = false;
            // 
            // openPatch
            // 
            openPatch.Filter = "MMR Patch files|*.mmr";
            // 
            // ttOutput
            // 
            ttOutput.Controls.Add(tpOutputSettings);
            ttOutput.Controls.Add(tpPatchSettings);
            ttOutput.Location = new Point(289, 470);
            ttOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ttOutput.Name = "ttOutput";
            ttOutput.SelectedIndex = 0;
            ttOutput.Size = new Size(490, 103);
            ttOutput.TabIndex = 15;
            ttOutput.SelectedIndexChanged += ttOutput_Changed;
            // 
            // tpOutputSettings
            // 
            tpOutputSettings.Controls.Add(tService);
            tpOutputSettings.Controls.Add(label11);
            tpOutputSettings.Controls.Add(bRandomise);
            tpOutputSettings.Controls.Add(tSeed);
            tpOutputSettings.Controls.Add(lSeed);
            tpOutputSettings.Location = new Point(4, 24);
            tpOutputSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpOutputSettings.Name = "tpOutputSettings";
            tpOutputSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpOutputSettings.Size = new Size(482, 75);
            tpOutputSettings.TabIndex = 0;
            tpOutputSettings.Text = "Output settings";
            tpOutputSettings.UseVisualStyleBackColor = true;
            // 
            // tService
            // 
            tService.Location = new Point(90, 41);
            tService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tService.MaxLength = 255;
            tService.Name = "tService";
            tService.Size = new Size(259, 23);
            tService.TabIndex = 6;
            tService.TextChanged += tService_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(1, 44);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 7;
            label11.Text = "Tracker URL:";
            // 
            // tpPatchSettings
            // 
            tpPatchSettings.Controls.Add(tPatch);
            tpPatchSettings.Controls.Add(bApplyPatch);
            tpPatchSettings.Controls.Add(bLoadPatch);
            tpPatchSettings.Location = new Point(4, 24);
            tpPatchSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpPatchSettings.Name = "tpPatchSettings";
            tpPatchSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpPatchSettings.Size = new Size(482, 75);
            tpPatchSettings.TabIndex = 1;
            tpPatchSettings.Text = "Patch settings";
            tpPatchSettings.UseVisualStyleBackColor = true;
            // 
            // tPatch
            // 
            tPatch.Location = new Point(7, 40);
            tPatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tPatch.Name = "tPatch";
            tPatch.ReadOnly = true;
            tPatch.Size = new Size(342, 23);
            tPatch.TabIndex = 17;
            // 
            // bLoadPatch
            // 
            bLoadPatch.Location = new Point(6, 7);
            bLoadPatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bLoadPatch.Name = "bLoadPatch";
            bLoadPatch.Size = new Size(120, 30);
            bLoadPatch.TabIndex = 16;
            bLoadPatch.Text = "Load Patch...";
            bLoadPatch.UseVisualStyleBackColor = true;
            bLoadPatch.Click += BLoadPatch_Click;
            // 
            // bSkip
            // 
            bSkip.Location = new Point(704, 591);
            bSkip.Name = "bSkip";
            bSkip.Size = new Size(75, 23);
            bSkip.TabIndex = 17;
            bSkip.Text = "Skip";
            bSkip.UseVisualStyleBackColor = true;
            bSkip.Visible = false;
            bSkip.Click += bSkip_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new Size(792, 627);
            Controls.Add(bSkip);
            Controls.Add(label1);
            Controls.Add(bopen);
            Controls.Add(tROMName);
            Controls.Add(lStatus);
            Controls.Add(gGameOutput);
            Controls.Add(ttOutput);
            Controls.Add(cDummy);
            Controls.Add(pProgress);
            Controls.Add(tSettings);
            Controls.Add(mMenu);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mMenu;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainForm";
            Load += mmrMain_Load;
            tSettings.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tOtherCustomizations.ResumeLayout(false);
            tOtherCustomization.ResumeLayout(false);
            tOtherCustomization.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabItemPool.ResumeLayout(false);
            tabItemPool.PerformLayout();
            tabGimmicks.ResumeLayout(false);
            tabGimmicks.PerformLayout();
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabComfort.ResumeLayout(false);
            gHintsGeneral.ResumeLayout(false);
            gHintsGeneral.PerformLayout();
            gGaroHints.ResumeLayout(false);
            gGaroHints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nMaxGaroCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)nMaxGaroFoolish).EndInit();
            ((System.ComponentModel.ISupportInitialize)nMaxGaroWotH).EndInit();
            gSpeedUps.ResumeLayout(false);
            gSpeedUps.PerformLayout();
            gHints.ResumeLayout(false);
            gHints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nMaxGossipCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)nMaxGossipFoolish).EndInit();
            ((System.ComponentModel.ISupportInitialize)nMaxGossipWotH).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            tabShortenCutscenes.ResumeLayout(false);
            tabCosmetics.ResumeLayout(false);
            gCosmeticOther.ResumeLayout(false);
            gCosmeticOther.PerformLayout();
            gCosmeticMusicSound.ResumeLayout(false);
            gCosmeticMusicSound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tLuckRollPercentage).EndInit();
            cHUDGroupBox.ResumeLayout(false);
            cHUDGroupBox.PerformLayout();
            cHUDTableLayoutPanel.ResumeLayout(false);
            cHUDTableLayoutPanel.PerformLayout();
            gGameOutput.ResumeLayout(false);
            gGameOutput.PerformLayout();
            mMenu.ResumeLayout(false);
            mMenu.PerformLayout();
            ttOutput.ResumeLayout(false);
            tpOutputSettings.ResumeLayout(false);
            tpOutputSettings.PerformLayout();
            tpPatchSettings.ResumeLayout(false);
            tpPatchSettings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button bopen;
        private System.Windows.Forms.OpenFileDialog openROM;
        private System.Windows.Forms.OpenFileDialog openPatch;
        private System.Windows.Forms.OpenFileDialog openLogic;
        private System.Windows.Forms.OpenFileDialog loadSettings;
        private System.Windows.Forms.TextBox tROMName;
        private System.Windows.Forms.ComboBox cMode;
        private System.Windows.Forms.Label lMode;
        private System.Windows.Forms.SaveFileDialog saveROM;
        private System.Windows.Forms.SaveFileDialog saveSettings;
        private System.Windows.Forms.ComboBox cLink;
        private System.Windows.Forms.Label lLink;
        private System.Windows.Forms.CheckBox cQText;
        private System.Windows.Forms.CheckBox cEnemy;
        private System.Windows.Forms.CheckBox cDEnt;
        private System.Windows.Forms.CheckBox cMixSongs;
        private System.Windows.Forms.ColorDialog cEnergy;
        private System.Windows.Forms.ColorDialog cTunic;
        private System.Windows.Forms.Button bRandomise;
        private System.Windows.Forms.TabControl tSettings;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabComfort;
        private System.Windows.Forms.Label lFloors;
        private System.Windows.Forms.Label lGravity;
        private System.Windows.Forms.Label lDType;
        private System.Windows.Forms.Label lDMult;
        private System.Windows.Forms.ComboBox cFloors;
        private System.Windows.Forms.ComboBox cDType;
        private System.Windows.Forms.ComboBox cDMult;
        private System.Windows.Forms.ComboBox cGravity;
        private System.Windows.Forms.SaveFileDialog saveWad;
        private System.Windows.Forms.CheckBox cVC;
        private System.Windows.Forms.CheckBox cN64;
        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mManual;
        private System.Windows.Forms.ToolStripMenuItem mAbout;
        private System.Windows.Forms.ToolStripSeparator mSep1;
        private System.Windows.Forms.OpenFileDialog openBROM;
        private System.Windows.Forms.ToolStripMenuItem mCustomise;
        private System.Windows.Forms.ProgressBar pProgress;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.TextBox tSeed;
        private System.Windows.Forms.Label lSeed;
        private System.Windows.Forms.CheckBox cDummy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cFreeHints;
        private System.Windows.Forms.CheckBox cPatch;
        private System.Windows.Forms.Button bApplyPatch;
        private System.Windows.Forms.TabControl ttOutput;
        private System.Windows.Forms.TabPage tpOutputSettings;
        private System.Windows.Forms.TabPage tpPatchSettings;
        private System.Windows.Forms.TextBox tPatch;
        private System.Windows.Forms.Button bLoadPatch;
        private System.Windows.Forms.CheckBox cClearHints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lNutAndStickDrops;
        private System.Windows.Forms.ComboBox cNutAndStickDrops;
        private System.Windows.Forms.ComboBox cClockSpeed;
        private System.Windows.Forms.CheckBox cHideClock;
        private System.Windows.Forms.CheckBox cNoDowngrades;
        private System.Windows.Forms.Label lGossip;
        private System.Windows.Forms.ComboBox cGossipHints;
        private System.Windows.Forms.CheckBox cShopAppearance;
        private System.Windows.Forms.CheckBox cEponaSword;
        private System.Windows.Forms.CheckBox cUpdateChests;
        private System.Windows.Forms.GroupBox gGameOutput;
        private System.Windows.Forms.TextBox tbUserLogic;
        private System.Windows.Forms.Button bLoadLogic;
        private System.Windows.Forms.ComboBox cBlastCooldown;
        private System.Windows.Forms.Label lBlastMask;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bStartingItemEditor;
        private System.Windows.Forms.TextBox tStartingItemList;
        private System.Windows.Forms.Label lCustomStartingItemAmount;
        private System.Windows.Forms.CheckBox cGoodDogRaceRNG;
        private System.Windows.Forms.CheckBox cFasterLabFish;
        private System.Windows.Forms.CheckBox cGoodDampeRNG;
        private System.Windows.Forms.CheckBox cSkipBeaver;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lJunkLocationsAmount;
        private System.Windows.Forms.Button bJunkLocationsEditor;
        private System.Windows.Forms.TextBox tJunkLocationsList;
        private System.Windows.Forms.ToolStripMenuItem mDPadConfig;
        private System.Windows.Forms.CheckBox cSunsSong;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.CheckBox cUnderwaterOcarina;
        private System.Windows.Forms.CheckBox cDrawHash;
        private System.Windows.Forms.CheckBox cQuestItemStorage;
        private System.Windows.Forms.CheckBox cDisableCritWiggle;
        private System.Windows.Forms.CheckBox cFastPush;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox gHints;
        private System.Windows.Forms.TabPage tabGimmicks;
        private System.Windows.Forms.CheckBox cHTMLLog;
        private System.Windows.Forms.CheckBox cSpoiler;
        private System.Windows.Forms.GroupBox gSpeedUps;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mLogicEdit;
        private System.Windows.Forms.CheckBox cEnableNightMusic;
        private System.Windows.Forms.CheckBox cFreestanding;
        private System.Windows.Forms.CheckBox cFDAnywhere;
        private System.Windows.Forms.CheckBox cArrowCycling;
        private System.Windows.Forms.CheckBox cFasterBank;
        private System.Windows.Forms.CheckBox cCloseCows;
        private System.Windows.Forms.ComboBox cLowHealthSFXComboBox;
        private System.Windows.Forms.Label lLowHealthSFXComboBox;
        private System.Windows.Forms.Button bToggleTricks;
        private System.Windows.Forms.CheckBox cByoAmmo;
        private System.Windows.Forms.CheckBox cDeathMoonCrash;
        private System.Windows.Forms.CheckBox cElegySpeedups;
        private System.Windows.Forms.CheckBox cContinuousDekuHopping;
        private System.Windows.Forms.CheckBox cProgressiveUpgrades;
        private System.Windows.Forms.Label lIceTraps;
        private System.Windows.Forms.ComboBox cIceTrapsAppearance;
        private System.Windows.Forms.ComboBox cIceTraps;
        private System.Windows.Forms.CheckBox cIceTrapQuirks;
        private System.Windows.Forms.TabPage tabCosmetics;
        private System.Windows.Forms.CheckBox cSFX;
        private System.Windows.Forms.CheckBox cTargettingStyle;
        private System.Windows.Forms.Label lTatl;
        private System.Windows.Forms.GroupBox cHUDGroupBox;
        private System.Windows.Forms.TableLayoutPanel cHUDTableLayoutPanel;
        private System.Windows.Forms.ComboBox cHUDHeartsComboBox;
        private System.Windows.Forms.Label cHeartsLabel;
        private System.Windows.Forms.Label cMagicLabel;
        private System.Windows.Forms.ComboBox cHUDMagicComboBox;
        private System.Windows.Forms.Button btn_hud;
        private System.Windows.Forms.Label lMusic;
        private System.Windows.Forms.CheckBox cCombatMusicDisable;
        private System.Windows.Forms.ComboBox cTatl;
        private System.Windows.Forms.ComboBox cMusic;
        private System.Windows.Forms.TabControl tFormCosmetics;
        private System.Windows.Forms.CheckBox cHueShiftMiscUI;
        private System.Windows.Forms.GroupBox gCosmeticOther;
        private System.Windows.Forms.GroupBox gCosmeticMusicSound;
        private System.Windows.Forms.TabPage tabShortenCutscenes;
        private System.Windows.Forms.TabControl tShortenCutscenes;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tOtherCustomizations;
        private System.Windows.Forms.TabPage tOtherCustomization;
        private System.Windows.Forms.TabPage tabItemPool;
        private System.Windows.Forms.TableLayoutPanel tableItemPool;
        private System.Windows.Forms.Button bItemPoolEdit;
        private System.Windows.Forms.TextBox tItemPool;
        private System.Windows.Forms.Label lItemPoolText;
        private System.Windows.Forms.ComboBox cStartingItems;
        private System.Windows.Forms.Label lStartingItems;
        private System.Windows.Forms.CheckBox cInstantPictobox;
        private System.Windows.Forms.CheckBox cImprovedPictobox;
        private System.Windows.Forms.CheckBox cHookshotAnySurface;
        private System.Windows.Forms.CheckBox cClimbMostSurfaces;
        private System.Windows.Forms.CheckBox cLenientGoronSpikes;
        private System.Windows.Forms.CheckBox cTargetHealth;
        private System.Windows.Forms.CheckBox cFreeScarecrow;
        private System.Windows.Forms.CheckBox cDoubleArcheryRewards;
        private System.Windows.Forms.CheckBox cFillWallet;
        private System.Windows.Forms.ComboBox cAutoInvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cInvisSparkle;
        private System.Windows.Forms.Panel pClassicItemPool;
        private System.Windows.Forms.CheckBox cItemPoolAdvanced;
        private System.Windows.Forms.Panel pLocationCategories;
        private System.Windows.Forms.GroupBox gGaroHints;
        private System.Windows.Forms.Label lGaroHints;
        private System.Windows.Forms.ComboBox cGaroHint;
        private System.Windows.Forms.CheckBox cMixGaroWithGossip;
        private System.Windows.Forms.CheckBox cClearGaroHints;
        private System.Windows.Forms.GroupBox gHintsGeneral;
        private System.Windows.Forms.CheckBox cHintImportance;
        private System.Windows.Forms.NumericUpDown nMaxGossipWotH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lGossipWothConfig;
        private System.Windows.Forms.NumericUpDown nMaxGaroCT;
        private System.Windows.Forms.NumericUpDown nMaxGaroFoolish;
        private System.Windows.Forms.NumericUpDown nMaxGaroWotH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nMaxGossipCT;
        private System.Windows.Forms.NumericUpDown nMaxGossipFoolish;
        private System.Windows.Forms.CheckBox cCustomGaroWoth;
        private System.Windows.Forms.CheckBox cCustomGossipWoth;
        private System.Windows.Forms.Button bCustomizeHintPriorities;
        private System.Windows.Forms.CheckBox cFreeGaroHints;
        private System.Windows.Forms.Label lLuckRoll;
        private System.Windows.Forms.NumericUpDown tLuckRollPercentage;
        private System.Windows.Forms.Button bSkip;
        private System.Windows.Forms.ComboBox cItemPlacement;
        private System.Windows.Forms.Label lItemPlacement;
        private System.Windows.Forms.Label lNumTricksEnabled;
        private System.Windows.Forms.TextBox tService;
        private System.Windows.Forms.Label label11;
    }
}

