using PEPlugin;
using PEPlugin.Pmx;
using System;
using System.Linq;
using System.Windows.Forms;
using PEPExtensions;

namespace RemoveMirrorVertexFromSelection
{
    public class RemoveMirrorVertexFromSelection : PEPluginClass
    {
        public RemoveMirrorVertexFromSelection() : base()
        {
        }

        public override string Name
        {
            get
            {
                return "鏡像頂点の選択を解除";
            }
        }

        public override string Version
        {
            get
            {
                return "0.0";
            }
        }

        public override string Description
        {
            get
            {
                return "鏡像頂点の選択を解除";
            }
        }

        public override IPEPluginOption Option
        {
            get
            {
                // boot時実行, プラグインメニューへの登録, メニュー登録名
                return new PEPluginOption(false, true, "鏡像頂点の選択を解除");
            }
        }

        public override void Run(IPERunArgs args)
        {
            try
            {
                if (ctrlForm == null)
                {
                    ctrlForm = new CtrlForm(args);
                    ctrlForm.Visible = true;
                }
                else
                {
                    ctrlForm.Format();
                    ctrlForm.Visible = !ctrlForm.Visible;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowException(ex);
            }
        }

        public override void Dispose()
        {
            if (ctrlForm != null)
            {
                ctrlForm.Close();
                ctrlForm = null;
            }
        }

        CtrlForm ctrlForm;
    }
}