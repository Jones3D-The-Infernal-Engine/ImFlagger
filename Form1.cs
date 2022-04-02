using Microsoft.VisualBasic;
using System.Globalization;
using System.Text.Json;

namespace ImFlagger
{
    public partial class Form1 : Form
    {
        private const string presetsFilename = "presets.json";
        readonly List<Preset> presets = new()
        {
            new Preset("No Preset", "", null),
            //new Preset("Actor flags", "Actor thing flags", new List<PresetFlagEntry>{
            //    new PresetFlagEntry(0x01, "Unknown"),
            //    new PresetFlagEntry(0x02, "Unknown"),
            //    new PresetFlagEntry(0x04, "Use light intensity", "Actor `intensity` param used."),
            //    new PresetFlagEntry(0x08, "Invulnerable", "Actor cannot be harmed by other things/physics."),
            //    new PresetFlagEntry(0x10, "Head is centered"),
            //    new PresetFlagEntry(0x20, "Explodes when killed", "Actor explodes when killed.\nThe `explode` Thing param must be set with explosion template."),
            //    new PresetFlagEntry(0x40, "Breath under water", "Actor won't drawn under water."),
            //    new PresetFlagEntry(0x80, "Invisible", "Actor is not visible to other actors."),
            //    new PresetFlagEntry(0x100, "Unknown"),
            //    new PresetFlagEntry(0x200, "Boss"),
            //    new PresetFlagEntry(0x400, "Deaf", "AI actor cannot hear other actors."),
            //    new PresetFlagEntry(0x800, "Blind", "AI Actor cannot see other actors."),
            //    new PresetFlagEntry(0x1000, "Unknown"),
            //    new PresetFlagEntry(0x2000, "Poisoned", "Actor was bitten or sting by snake, spider, scorpion etc... and is poisoned.\nHUD shows death icon for player."),
            //    new PresetFlagEntry(0x4000, "Unknown"),
            //    new PresetFlagEntry(0x8000, "Unknown"),
            //    new PresetFlagEntry(0x10000, "Unknown"),
            //    new PresetFlagEntry(0x20000, "Delay fire", "AI actor will delay fire action."),
            //    new PresetFlagEntry(0x40000, "Immobile", "Actor cannot move."),
            //    new PresetFlagEntry(0x80000, "Unknown"),
            //    new PresetFlagEntry(0x100000, "No target", "Player won't aim with weapon at actor."),
            //    new PresetFlagEntry(0x200000, "Disabled"),
            //    new PresetFlagEntry(0x400000, "Player killed", "This flag is set by game engine."),
            //    new PresetFlagEntry(0x800000, "Unknown"),
            //    new PresetFlagEntry(0x1000000, "Unknown"),
            //    new PresetFlagEntry(0x2000000, "Unknown"),
            //    new PresetFlagEntry(0x4000000, "Unknown"),
            //    new PresetFlagEntry(0x8000000, "Unknown"),
            //    new PresetFlagEntry(0x10000000, "Flayer move"),
            //    new PresetFlagEntry(0x20000000, "Unknown"),
            //    new PresetFlagEntry(0x40000000, "Electric whip", "Player has electric whip."),
            //    new PresetFlagEntry(0x80000000, "Arachnid", "Actor is spider, scorpion etc...\nFlag causes the gen_a4sprite_blood_grn.mat and +vulcansplort to be created when actor is hit."),
            //}),
            //new Preset("Face flags", "Polygon face flags", new List<PresetFlagEntry>{
            //    new PresetFlagEntry(0x01, "Double sided", "Disables face backface culling for polygon face."),
            //    new PresetFlagEntry(0x02, "Translucent", " Face has texture with alpha channel and is put in alpha render queue.\nThis flag applies to adjoin surfaces and Thing 3D model surfaces."),
            //    new PresetFlagEntry(0x04, "Clamp texture in X", "Mapped texture is clamped in X instead of being repeated (wrapped)."),
            //    new PresetFlagEntry(0x08, "Clamp texture in Y", "Mapped texture is clamped in Y instead of being repeated (wrapped)."),
            //    new PresetFlagEntry(0x10, "Point texture filtering", "Disables bilinear texture filtering for the polygon texture."),
            //    new PresetFlagEntry(0x20, "ZWrite disabled", "Disables ZWrite for the polygon face."),
            //    new PresetFlagEntry(0x40, "Ledge (3DO model)", "Player can hang on the ledge of this polygon face. Applies only to 3DO model.\nSame effect as surface flag Ledge = 0x1000000 for world surface"),
            //    new PresetFlagEntry(0x80, "Unknown"),
            //    new PresetFlagEntry(0x100, "Fog enabled", "Enables fog rendering for the face polygon.\nThis flag is by default set for all faces but sky surfaces."),
            //    new PresetFlagEntry(0x200, "WhipAim (3DO model)", "Applies to polygon face of 3DO model and marks the whip aim surface.\nSame effect as surface flag `WhipAim` = 0x10000000."),
            //}),
            //new Preset("Surface flags", "World surface flags", new List<PresetFlagEntry>{
            //    new PresetFlagEntry(0x01, "Floor", "Surface is ground floor."),
            //    new PresetFlagEntry(0x02, "COG linked", "Surface is linked in COG."),
            //    new PresetFlagEntry(0x04, "Collision", "Surface has collision."),
            //    new PresetFlagEntry(0x08, "AI cannot walk on surface", "AI won't walk on this surface."),
            //    new PresetFlagEntry(0x10, "2x scale", "Affects SlideWall() COG function.\nBy default the animating surface matrix is resized to 320x320, this flag resizes it to 640x640."),
            //    new PresetFlagEntry(0x20, "1/2 scale", "Affects SlideWall() COG function.\nBy default the animating surface matrix is resized to 320x320, this flag resizes it to 160x160."),
            //    new PresetFlagEntry(0x40, "1/8 scale",  "Affects SlideWall() COG function.\nBy default the animating surface matrix is resized to 320x320, this flag resizes it to 40x40."),
            //    new PresetFlagEntry(0x80, "Aetherium", "Aetherium surface.\nIf surface is hit or walk on by a thing it produces 'aetherium' environment fx sound, i.e.: fol_in_lrunaet.wav, fol_in_rrunaet.wav."),
            //    new PresetFlagEntry(0x100, "Unknown"),
            //    new PresetFlagEntry(0x200, "Horizon sky", "Surface is part of sky box.\ne.g.: defined in 02_riv."),
            //    new PresetFlagEntry(0x400, "Ceiling sky", "Surface is part of ceiling sky.\ne.g.: defined in 00_cyn."),
            //    new PresetFlagEntry(0x800, "Scrolling", "Set by SlideWall() COG function."),
            //    new PresetFlagEntry(0x1000, "Kill floor", "Player dies if it touches the surface.\ne.g.: cyn_killfloor.cog"),
            //    new PresetFlagEntry(0x2000, "Climbable", "Player can climb on this surface.\ne.g.:ladder"),
            //    new PresetFlagEntry(0x4000, "Track", "Surface is part of a railroad track, e.g.: minecart track."),
            //    new PresetFlagEntry(0x8000, "Surface changed", "Used by the engine to mark the surface for rendering."),
            //    new PresetFlagEntry(0x10000, "Metal", "Metal surface."),
            //    new PresetFlagEntry(0x20000, "Water", "Water surface."),
            //    new PresetFlagEntry(0x40000, "Shallow water", "Shallow water surface."),
            //    new PresetFlagEntry(0x80000, "Earth", "Dirt surface."),
            //    new PresetFlagEntry(0x100000, "Web", "Surface is spider web."),
            //    new PresetFlagEntry(0x200000, "Lava", "Lava or frozen water surface."),
            //    new PresetFlagEntry(0x400000, "Snow", "Snow surface."),
            //    new PresetFlagEntry(0x800000, "Wood", "Wood surface."),
            //    new PresetFlagEntry(0x1000000, "Ledge", "Surface is ledge from which player can hang on."),
            //    new PresetFlagEntry(0x2000000, "Water climb out ledge", "Surface is ledge above the water from which the player can climb out of the water."),
            //    new PresetFlagEntry(0x4000000, "1/4 scale", "Affects SlideWall() COG function.\nBy default the animating surface matrix is resized to 320x320, this flag resizes it to 80x80."),
            //    new PresetFlagEntry(0x8000000, "4x scale", "Affects SlideWall() COG function.\nBy default the animating surface matrix is resized to 320x320, this flag resizes it to 1280x1280."),
            //    new PresetFlagEntry(0x10000000, "Whip aim", "Player aims for whippable object on this surface."),
            //    new PresetFlagEntry(0x20000000, "Echo", "Indoor surface. Walk on this surface produces *echo sound fx."),
            //    new PresetFlagEntry(0x40000000, "Wood echo", "Indoor wood surface. Walk on this surface produces *echo sound fx."),
            //    new PresetFlagEntry(0x80000000, "Earth echo", "Indoor dirt surface. Walk on this surface produces *echo sound fx."),
            //}),
            //new Preset("Thing flags", "", new List<PresetFlagEntry>{
            //    new PresetFlagEntry(0x01, "Emits light", "Thing object emits light. e.g. `light` param set."),
            //    new PresetFlagEntry(0x02, "Destroyed", "Thing is destroyed and will be removed from the game."),
            //    new PresetFlagEntry(0x04, "No weapon collide"),
            //    new PresetFlagEntry(0x08, "Whip climbable", "On the WhipAim surface player can mount whip on thing and climb up the whip. e.g.: shs_whip.cog\nNote: if set, thing can't have flag `Whip swingable` set"),
            //    new PresetFlagEntry(0x10, "Invisible", "Thing is invisible but touchable unlike `Hidden`."),
            //    new PresetFlagEntry(0x20, "Unknown"),
            //    new PresetFlagEntry(0x40, "Can stand on", "nub_lightning.cog"),
            //    new PresetFlagEntry(0x80, "Mountable", "pyr_fixminecar.cog, shs_barrel.cog"),
            //    new PresetFlagEntry(0x100, "Unknown"),
            //    new PresetFlagEntry(0x200, "Dying", "Used in combination with 'lifeleft' param.\nUsually set by the engine marking the object has been killed and to be removed from the game."),
            //    new PresetFlagEntry(0x400, "COG linked", "Thing is linked in COG."),
            //    new PresetFlagEntry(0x800, "No crush"),
            //    new PresetFlagEntry(0x1000, "Unknown"),
            //    new PresetFlagEntry(0x2000, "Wood", "Thing is wood object."),
            //    new PresetFlagEntry(0x4000, "Has shadow"),
            //    new PresetFlagEntry(0x8000, "Unknown"),
            //    new PresetFlagEntry(0x10000, "Snow", "Thing is snow object."),
            //    new PresetFlagEntry(0x20000, "Sending pulse event", "Thing sends pulse interval timeout event to its COG.\nUsually set by COG script."),
            //    new PresetFlagEntry(0x40000, "Sending timer event", "Thing sends timer timeout event to its COG.\nUsually set by COG script"),
            //    new PresetFlagEntry(0x80000, "Hidden", "Thing is hidden and disabled."),
            //    new PresetFlagEntry(0x100000, "Seen", "Mark Thing to be already seen by player (camera).\n For example see: gen_bubblegen.cog, gen_watersplash.cog."),
            //    new PresetFlagEntry(0x200000, "Unknown"),
            //    new PresetFlagEntry(0x400000, "Metal", "Thing is metal object."),
            //    new PresetFlagEntry(0x800000, "Earth", "Thing is earth (dirt) object."),
            //    new PresetFlagEntry(0x1000000, "No Sound", "Thing makes not sound."),
            //    new PresetFlagEntry(0x2000000, "Underwater", "Thing is in or under water.\ne.g.: swimming"),
            //    new PresetFlagEntry(0x4000000, "Climbable create", "Thing is create like object that player can climb on."),
            //    new PresetFlagEntry(0x8000000, "Destroyed in water", "Thing is destroyed when enters water."),
            //    new PresetFlagEntry(0x10000000, "Destroyed in air", "Thing is destroyed when enters water."),
            //    new PresetFlagEntry(0x20000000, "Generates splash effect", "Sends splash message to it's COG."),
            //    new PresetFlagEntry(0x40000000, "Movable", "Thing is movable/pushable."),
            //    new PresetFlagEntry(0x80000000, "Whip swingable", "On the `WhipAim` surface player can whip swing using this thing as whip mount point.\ne.g.: In 00_cyn thing whip_branch."),
            //})
        };

        public Form1()
        {
            InitializeComponent();

            // Set flag bits change notifier
            for (uint i = 0; i < 32; i++)
            {
                var cb = GetBitCheckBox(i);
                if (cb != null)
                    cb.CheckedChanged += new System.EventHandler(BitCheckedChanged);
            }

            // Set presets
            try
            {
                if (File.Exists(presetsFilename))
                {
                    string jsonString = File.ReadAllText(presetsFilename);
                    if (jsonString != null && jsonString.Length > 0)
                    {
                        var presetsFromFile = JsonSerializer.Deserialize<Preset[]>(jsonString)!;
                        presets.AddRange(presetsFromFile);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load preset from file:\n\n{ex.Message}", "Error loading preset", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cxFlagsPreset.Items.Clear();
            foreach (var p in presets)
                cxFlagsPreset.Items.Add(p);
            cxFlagsPreset.SelectedIndex = 0;

            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string outJsonString =  JsonSerializer.Serialize(presets, options);
            //File.WriteAllText(presetFilename, outJsonString);

            //Console.WriteLine(jsonString);


            //private string[] listFlagSets = new string[]
            //{
            //    "No Preset",
            //    "Actor",
            //    "Explosion",
            //    "Item",
            //    "Thing",
            //    "Particle",
            //    "Physics",
            //    "Polygon Face",
            //    "Surface",
            //    "Surface Adjoin",
            //    "Weapon",
            //};
        }

        private void cxFlagsPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = cxFlagsPreset.SelectedItem;
            SetPreset((item as Preset));
        }
        private void SetPreset(Preset? preset)
        {
            ResetBitTable(false);
            if (preset == null) return;
            tooltip.SetToolTip(cxFlagsPreset, preset.description);

            foreach (var f in preset.flags)
            {
                var bitPos = f.GetBitPosition();
                var cb = GetBitCheckBox(bitPos);
                if (cb != null)
                {
                    cb.Text = $"0x{f.flag:X2} - {f.name}";
                    cb.Enabled = f.enabled;
                    tooltip.SetToolTip(cb, f.description);
                }
            }
        }

        private const string hexLetters = "0123456789abcdefABCDEF";

        private void ebFlags_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (hexLetters.Contains(Strings.Chr(e.KeyValue)) || e.KeyCode == Keys.Back)
                    return;

                switch (e.KeyCode)
                {
                    case Keys.Back:
                    case Keys.NumPad0:
                    case Keys.NumPad1:
                    case Keys.NumPad2:
                    case Keys.NumPad3:
                    case Keys.NumPad4:
                    case Keys.NumPad5:
                    case Keys.NumPad6:
                    case Keys.NumPad7:
                    case Keys.NumPad8:
                    case Keys.NumPad9:
                        return;
                }
            }
            catch { }
            // throw away enterd char
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void ebFlags_TextChanged(object sender, EventArgs e)
        {
            if (ebFlags.Text.StartsWith("0x"))
            {
                ebFlags.Text = ebFlags.Text[2..];
                return;
            }
            else if (ebFlags.Text.Length > 8)
            {
                int pos = ebFlags.SelectionStart;
                ebFlags.Text = ebFlags.Text[..8];
                ebFlags.SelectionStart = pos;
                return;
            }

            if (!GetFlags(out int flags) && ebFlags.Text.Length > 0)
            {
                ebFlags.Text = "00";
                ebFlags.SelectAll();
                return;
            }

            bitEventHandlerDisabled = true;
            for (int i = 0; i < 32; i++)
            {
                SetBitChecked((uint)i, ((1 << i) & flags) != 0);
            }
            bitEventHandlerDisabled = false;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0x" + ebFlags.Text);
        }

        private void handlePastedText(string pastedText)
        {
            int pos = ebFlags.SelectionStart;
            var curText = ebFlags.Text;
            ebFlags.Text = pastedText;
            if (ebFlags.Text == "00" && !(pastedText == "00" || pastedText == "0x00" || pastedText == "0" || pastedText == "0x0"))
                ebFlags.Text = curText;
            ebFlags.SelectionStart = pos;
        }

        private void BitCheckedChanged(object sender, EventArgs e)
        {
            if (bitEventHandlerDisabled) return;
            var cb = (CheckBox)sender;
            var sid = cb.Name.Remove(0, "cbBit".Length);
            ebFlags.TextChanged -= new System.EventHandler(ebFlags_TextChanged);

            var flag = 1 << int.Parse(sid);
            if (!GetFlags(out int flags)) return; // sanity check
            if (cb.Checked)
                flags |= flag;
            else
                flags &= ~flag;
            ebFlags.Text = $"{flags:X2}";
            ebFlags.TextChanged += new System.EventHandler(ebFlags_TextChanged);
        }

        private void ResetBitTable(bool uncheck)
        {
            bitEventHandlerDisabled = true;
            for (int i = 0; i < 32; i++)
            {
                var cb = GetBitCheckBox((uint)i);
                if (cb == null) continue; // sanity check
                cb.Text = $"0x{1 << i:X2}";
                cb.Enabled = true;
                if (uncheck)
                    cb.Checked = false;
                tooltip.SetToolTip(cb, "");
            }
            bitEventHandlerDisabled = false;
        }
        private void SetBit(uint idx, string text, bool isChecked)
        {
            var cb = GetBitCheckBox(idx);
            if (cb != null)
            {
                cb.Text = text;
                cb.Checked = isChecked;
            }
        }

        private void SetBitText(uint idx, string text)
        {
            var cb = GetBitCheckBox(idx);
            if (cb != null)
                cb.Text = text;
        }

        private void SetBitChecked(uint idx, bool isChecked)
        {
            var cb = GetBitCheckBox(idx);
            if (cb != null) cb.Checked = isChecked;
        }

        private CheckBox? GetBitCheckBox(uint i)
        {
            return (CheckBox?)typeof(Form1)
                    ?.GetField($"cbBit{i}",
                        System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance
                    )
                    ?.GetValue(this);
        }

        private bool GetFlags(out int flags)
        {
            return int.TryParse(ebFlags.Text, NumberStyles.HexNumber,
                CultureInfo.InvariantCulture, out flags
            );
        }

        private void Reset()
        {
            ResetBitTable(true);
            ebFlags.Clear();
        }

        private void copyCtxMenuEbFlags_Click(object sender, EventArgs e)
        {
            btnCopy_Click(sender, e);
        }

        private void pasteCtxMenuEbFlags_Click(object sender, EventArgs e)
        {
            handlePastedText(Clipboard.GetText());
        }

        private void ebFlags_Leave(object sender, EventArgs e)
        {
            if (ebFlags.Text.Length < 1) ebFlags.Text = "00";
        }
    }
}