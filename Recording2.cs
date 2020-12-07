﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest4
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording2 recording.
    /// </summary>
    [TestModule("0bc6bfa3-f51e-4c47-b056-3dfc945e5636", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest4Repository repository.
        /// </summary>
        public static MyTest4Repository repo = MyTest4Repository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
            NameOfItem = "NotFound";
            Price = "";
            i = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Price;

        /// <summary>
        /// Gets or sets the value of variable Price.
        /// </summary>
        [TestVariable("630a5441-16ef-4b0c-bda8-04f6eb65cfb7")]
        public string Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable i.
        /// </summary>
        [TestVariable("218aab6e-112e-45d5-89d2-1a6fe7cf1617")]
        public string i
        {
            get { return repo.i; }
            set { repo.i = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NameOfItem.
        /// </summary>
        [TestVariable("3a8c680c-c06a-4273-aff5-e13dbaf2651d")]
        public string NameOfItem
        {
            get { return repo.NameOfItem; }
            set { repo.NameOfItem = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'VasarlasSportoraOkosoraKiegeszitőA.ProductName' and assigning its value to variable 'NameOfItem'.", repo.VasarlasSportoraOkosoraKiegeszitőA.ProductNameInfo, new RecordItemIndex(0));
            NameOfItem = repo.VasarlasSportoraOkosoraKiegeszitőA.ProductName.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'VasarlasSportoraOkosoraKiegeszitőA.ProductPrice' and assigning its value to variable 'Price'.", repo.VasarlasSportoraOkosoraKiegeszitőA.ProductPriceInfo, new RecordItemIndex(1));
            Price = repo.VasarlasSportoraOkosoraKiegeszitőA.ProductPrice.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NameOfItem' with focus on 'Excel'.", repo.Excel.SelfInfo, new RecordItemIndex(2));
            repo.Excel.Self.PressKeys(NameOfItem);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'Excel'.", repo.Excel.SelfInfo, new RecordItemIndex(3));
            repo.Excel.Self.PressKeys("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Price'.", new RecordItemIndex(4));
            Keyboard.Press(Price);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}{Home}'.", new RecordItemIndex(5));
            Keyboard.Press("{Return}{Home}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "$Iteration", new RecordItemIndex(6));
            
            i = IncrementI(i);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
