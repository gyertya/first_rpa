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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest4
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest4Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("060658ae-2975-49c0-a8d0-d1c0d53ccceb")]
    public partial class MyTest4Repository : RepoGenBaseFolder
    {
        static MyTest4Repository instance = new MyTest4Repository();
        MyTest4RepositoryFolders.ArukeresőHuArakEsTermekekOesszehaAppFolder _arukeresőhuarakestermekekoesszeha;
        MyTest4RepositoryFolders.VasarlasSportoraOkosoraKiegeszitőAAppFolder _vasarlassportoraokosorakiegeszitőa;
        MyTest4RepositoryFolders.ExcelAppFolder _excel;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest4Repository element repository.
        /// </summary>
        [RepositoryFolder("060658ae-2975-49c0-a8d0-d1c0d53ccceb")]
        public static MyTest4Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest4Repository() 
            : base("MyTest4Repository", "/", null, 0, false, "060658ae-2975-49c0-a8d0-d1c0d53ccceb", ".\\RepositoryImages\\MyTest4Repository060658ae.rximgres")
        {
            _arukeresőhuarakestermekekoesszeha = new MyTest4RepositoryFolders.ArukeresőHuArakEsTermekekOesszehaAppFolder(this);
            _vasarlassportoraokosorakiegeszitőa = new MyTest4RepositoryFolders.VasarlasSportoraOkosoraKiegeszitőAAppFolder(this);
            _excel = new MyTest4RepositoryFolders.ExcelAppFolder(this);
        }

#region Variables

        string _NameOfItem = "NotFound";

        /// <summary>
        /// Gets or sets the value of variable NameOfItem.
        /// </summary>
        [TestVariable("0400daa3-ae83-4b29-b709-34e61781a125")]
        public string NameOfItem
        {
            get { return _NameOfItem; }
            set { _NameOfItem = value; }
        }

        string _i = "1";

        /// <summary>
        /// Gets or sets the value of variable i.
        /// </summary>
        [TestVariable("bfdecc38-b710-483b-9d50-bb9f7c73bdf0")]
        public string i
        {
            get { return _i; }
            set { _i = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("060658ae-2975-49c0-a8d0-d1c0d53ccceb")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ArukeresőHuArakEsTermekekOesszeha folder.
        /// </summary>
        [RepositoryFolder("81ed4c70-e124-4f24-aad7-4863c9d19e53")]
        public virtual MyTest4RepositoryFolders.ArukeresőHuArakEsTermekekOesszehaAppFolder ArukeresőHuArakEsTermekekOesszeha
        {
            get { return _arukeresőhuarakestermekekoesszeha; }
        }

        /// <summary>
        /// The VasarlasSportoraOkosoraKiegeszitőA folder.
        /// </summary>
        [RepositoryFolder("08c3c90c-39b2-4d94-828a-c5add3e85359")]
        public virtual MyTest4RepositoryFolders.VasarlasSportoraOkosoraKiegeszitőAAppFolder VasarlasSportoraOkosoraKiegeszitőA
        {
            get { return _vasarlassportoraokosorakiegeszitőa; }
        }

        /// <summary>
        /// The Excel folder.
        /// </summary>
        [RepositoryFolder("beb05c59-d7cb-4c17-b4c0-813ac746ef47")]
        public virtual MyTest4RepositoryFolders.ExcelAppFolder Excel
        {
            get { return _excel; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest4RepositoryFolders
    {
        /// <summary>
        /// The ArukeresőHuArakEsTermekekOesszehaAppFolder folder.
        /// </summary>
        [RepositoryFolder("81ed4c70-e124-4f24-aad7-4863c9d19e53")]
        public partial class ArukeresőHuArakEsTermekekOesszehaAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _inputtagstInfo;
            RepoItemInfo _atagkeresesInfo;
            RepoItemInfo _sportoraokosorakiegeszitőInfo;

            /// <summary>
            /// Creates a new ArukeresőHuArakEsTermekekOesszeha  folder.
            /// </summary>
            public ArukeresőHuArakEsTermekekOesszehaAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ArukeresőHuArakEsTermekekOesszeha", "/dom[@domain='www.arukereso.hu']", parentFolder, 30000, null, false, "81ed4c70-e124-4f24-aad7-4863c9d19e53", "")
            {
                _inputtagstInfo = new RepoItemInfo(this, "InputTagSt", ".//input[#'st']", 30000, null, "2cccc0ca-2801-4d1a-916a-3b70a7a4d994");
                _atagkeresesInfo = new RepoItemInfo(this, "ATagKereses", ".//form[#'aksearch']//a[@innertext=' Keresés']", 30000, null, "dc1b9e29-cede-4bca-b3d8-a7037d523737");
                _sportoraokosorakiegeszitőInfo = new RepoItemInfo(this, "SportoraOkosoraKiegeszitő", ".//section[#'filter-bar']/div[2]/ul/?/?/a[@innertext>'Sportóra, okosóra kiegész']", 30000, null, "da2db12f-10d6-49f3-a14e-f282f97aabf2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("81ed4c70-e124-4f24-aad7-4863c9d19e53")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("81ed4c70-e124-4f24-aad7-4863c9d19e53")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The InputTagSt item.
            /// </summary>
            [RepositoryItem("2cccc0ca-2801-4d1a-916a-3b70a7a4d994")]
            public virtual Ranorex.InputTag InputTagSt
            {
                get
                {
                    return _inputtagstInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputTagSt item info.
            /// </summary>
            [RepositoryItemInfo("2cccc0ca-2801-4d1a-916a-3b70a7a4d994")]
            public virtual RepoItemInfo InputTagStInfo
            {
                get
                {
                    return _inputtagstInfo;
                }
            }

            /// <summary>
            /// The ATagKereses item.
            /// </summary>
            [RepositoryItem("dc1b9e29-cede-4bca-b3d8-a7037d523737")]
            public virtual Ranorex.ATag ATagKereses
            {
                get
                {
                    return _atagkeresesInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ATagKereses item info.
            /// </summary>
            [RepositoryItemInfo("dc1b9e29-cede-4bca-b3d8-a7037d523737")]
            public virtual RepoItemInfo ATagKeresesInfo
            {
                get
                {
                    return _atagkeresesInfo;
                }
            }

            /// <summary>
            /// The SportoraOkosoraKiegeszitő item.
            /// </summary>
            [RepositoryItem("da2db12f-10d6-49f3-a14e-f282f97aabf2")]
            public virtual Ranorex.ATag SportoraOkosoraKiegeszitő
            {
                get
                {
                    return _sportoraokosorakiegeszitőInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The SportoraOkosoraKiegeszitő item info.
            /// </summary>
            [RepositoryItemInfo("da2db12f-10d6-49f3-a14e-f282f97aabf2")]
            public virtual RepoItemInfo SportoraOkosoraKiegeszitőInfo
            {
                get
                {
                    return _sportoraokosorakiegeszitőInfo;
                }
            }
        }

        /// <summary>
        /// The VasarlasSportoraOkosoraKiegeszitőAAppFolder folder.
        /// </summary>
        [RepositoryFolder("08c3c90c-39b2-4d94-828a-c5add3e85359")]
        public partial class VasarlasSportoraOkosoraKiegeszitőAAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _orderdropdownInfo;
            RepoItemInfo _atagdragakInfo;
            RepoItemInfo _productnameInfo;
            RepoItemInfo _productpriceInfo;

            /// <summary>
            /// Creates a new VasarlasSportoraOkosoraKiegeszitőA  folder.
            /// </summary>
            public VasarlasSportoraOkosoraKiegeszitőAAppFolder(RepoGenBaseFolder parentFolder) :
                    base("VasarlasSportoraOkosoraKiegeszitőA", "/dom[@domain='sportora-okosora-kiegeszito.arukereso.hu']", parentFolder, 30000, null, false, "08c3c90c-39b2-4d94-828a-c5add3e85359", "")
            {
                _orderdropdownInfo = new RepoItemInfo(this, "OrderDropdown", ".//a[#'order-dropdown']", 30000, null, "fe34b9fe-c4df-4218-9e3f-d8eb84ba53cc");
                _atagdragakInfo = new RepoItemInfo(this, "ATagDragak", ".//span[#'orderby-container']//a[@innertext=' Drágák']", 30000, null, "973c6eb9-8782-4ef9-b1c0-f3c5008f587b");
                _productnameInfo = new RepoItemInfo(this, "ProductName", ".//div[#'product-list']/div[2]/div[$i]//h2/a", 30000, null, "87095f23-44fb-47fd-a674-dec987eef26a");
                _productpriceInfo = new RepoItemInfo(this, "ProductPrice", ".//div[#'product-list']/div[2]/div[$i]/div[1]/div[3]/a[1]", 30000, null, "b24e2096-39b3-4e50-b2fe-e61df799b6b3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("08c3c90c-39b2-4d94-828a-c5add3e85359")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("08c3c90c-39b2-4d94-828a-c5add3e85359")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The OrderDropdown item.
            /// </summary>
            [RepositoryItem("fe34b9fe-c4df-4218-9e3f-d8eb84ba53cc")]
            public virtual Ranorex.ATag OrderDropdown
            {
                get
                {
                    return _orderdropdownInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The OrderDropdown item info.
            /// </summary>
            [RepositoryItemInfo("fe34b9fe-c4df-4218-9e3f-d8eb84ba53cc")]
            public virtual RepoItemInfo OrderDropdownInfo
            {
                get
                {
                    return _orderdropdownInfo;
                }
            }

            /// <summary>
            /// The ATagDragak item.
            /// </summary>
            [RepositoryItem("973c6eb9-8782-4ef9-b1c0-f3c5008f587b")]
            public virtual Ranorex.ATag ATagDragak
            {
                get
                {
                    return _atagdragakInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ATagDragak item info.
            /// </summary>
            [RepositoryItemInfo("973c6eb9-8782-4ef9-b1c0-f3c5008f587b")]
            public virtual RepoItemInfo ATagDragakInfo
            {
                get
                {
                    return _atagdragakInfo;
                }
            }

            /// <summary>
            /// The ProductName item.
            /// </summary>
            [RepositoryItem("87095f23-44fb-47fd-a674-dec987eef26a")]
            public virtual Ranorex.ATag ProductName
            {
                get
                {
                    return _productnameInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ProductName item info.
            /// </summary>
            [RepositoryItemInfo("87095f23-44fb-47fd-a674-dec987eef26a")]
            public virtual RepoItemInfo ProductNameInfo
            {
                get
                {
                    return _productnameInfo;
                }
            }

            /// <summary>
            /// The ProductPrice item.
            /// </summary>
            [RepositoryItem("b24e2096-39b3-4e50-b2fe-e61df799b6b3")]
            public virtual Ranorex.ATag ProductPrice
            {
                get
                {
                    return _productpriceInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ProductPrice item info.
            /// </summary>
            [RepositoryItemInfo("b24e2096-39b3-4e50-b2fe-e61df799b6b3")]
            public virtual RepoItemInfo ProductPriceInfo
            {
                get
                {
                    return _productpriceInfo;
                }
            }
        }

        /// <summary>
        /// The ExcelAppFolder folder.
        /// </summary>
        [RepositoryFolder("beb05c59-d7cb-4c17-b4c0-813ac746ef47")]
        public partial class ExcelAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _paneInfo;
            RepoItemInfo _cella1Info;
            RepoItemInfo _formulabarInfo;

            /// <summary>
            /// Creates a new Excel  folder.
            /// </summary>
            public ExcelAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Excel", "/form[@processname='EXCEL']", parentFolder, 30000, null, true, "beb05c59-d7cb-4c17-b4c0-813ac746ef47", "")
            {
                _paneInfo = new RepoItemInfo(this, "Pane", "element[@class='FullpageUIHost']/container[@class='NetUIHWND']/container[@accessiblename='']", 30000, null, "e32f5a72-275e-4f9a-a3cb-1a66ebe1d4e2");
                _cella1Info = new RepoItemInfo(this, "CellA1", ".//table[@name='Sheet1']/row[@index='1']/cell", 30000, null, "32c78e63-f6a1-4d4a-9dd3-bd71df2de14a");
                _formulabarInfo = new RepoItemInfo(this, "FormulaBar", "?/?/text[@automationid='FormulaBar']", 30000, null, "26af649f-fcb2-483a-9c45-faae1c7b454e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("beb05c59-d7cb-4c17-b4c0-813ac746ef47")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("beb05c59-d7cb-4c17-b4c0-813ac746ef47")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Pane item.
            /// </summary>
            [RepositoryItem("e32f5a72-275e-4f9a-a3cb-1a66ebe1d4e2")]
            public virtual Ranorex.Container Pane
            {
                get
                {
                    return _paneInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Pane item info.
            /// </summary>
            [RepositoryItemInfo("e32f5a72-275e-4f9a-a3cb-1a66ebe1d4e2")]
            public virtual RepoItemInfo PaneInfo
            {
                get
                {
                    return _paneInfo;
                }
            }

            /// <summary>
            /// The CellA1 item.
            /// </summary>
            [RepositoryItem("32c78e63-f6a1-4d4a-9dd3-bd71df2de14a")]
            public virtual Ranorex.Cell CellA1
            {
                get
                {
                    return _cella1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellA1 item info.
            /// </summary>
            [RepositoryItemInfo("32c78e63-f6a1-4d4a-9dd3-bd71df2de14a")]
            public virtual RepoItemInfo CellA1Info
            {
                get
                {
                    return _cella1Info;
                }
            }

            /// <summary>
            /// The FormulaBar item.
            /// </summary>
            [RepositoryItem("26af649f-fcb2-483a-9c45-faae1c7b454e")]
            public virtual Ranorex.Text FormulaBar
            {
                get
                {
                    return _formulabarInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The FormulaBar item info.
            /// </summary>
            [RepositoryItemInfo("26af649f-fcb2-483a-9c45-faae1c7b454e")]
            public virtual RepoItemInfo FormulaBarInfo
            {
                get
                {
                    return _formulabarInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
