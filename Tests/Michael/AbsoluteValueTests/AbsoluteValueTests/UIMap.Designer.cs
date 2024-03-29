﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace AbsoluteValueTests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Test ABS(-1), expect 1
        /// </summary>
        public void TestABSMinusOne()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            WinComboBox uIItemComboBox = this.UIGraphCalcWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(412, 193));

            // Select 'abs(-1)' in combo box
            uIItemComboBox.EditableItem = this.TestABSMinusOneParams.UIItemComboBoxEditableItem;

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(602, 407));
        }
        
        /// <summary>
        /// TEST ABS (-(1/4)), expect 0.25
        /// </summary>
        public void TestABSMinusOnefourth()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            WinComboBox uIItemComboBox = this.UIGraphCalcWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(416, 196));

            // Select 'abs(-(1/4))' in combo box
            uIItemComboBox.EditableItem = this.TestABSMinusOnefourthParams.UIItemComboBoxEditableItem;

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(597, 408));
        }
        
        /// <summary>
        /// Test ABS(-1,000,000), expect 1,000,000
        /// </summary>
        public void TestABSMinusOneMillion()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            WinComboBox uIItemComboBox = this.UIGraphCalcWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(414, 190));

            // Select 'abs(-1000000)' in combo box
            uIItemComboBox.EditableItem = this.TestABSMinusOneMillionParams.UIItemComboBoxEditableItem;

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(611, 406));
        }
        
        /// <summary>
        /// TEST ABS(-1-3), expect 4
        /// </summary>
        public void TestABSMinusOneMinusThree()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            WinComboBox uIItemComboBox = this.UIGraphCalcWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(408, 189));

            // Select 'abs(-1-3)' in combo box
            uIItemComboBox.EditableItem = this.TestABSMinusOneMinusThreeParams.UIItemComboBoxEditableItem;

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(608, 405));
        }
        
        /// <summary>
        /// Test ABS(-1.2), expect 1.2
        /// </summary>
        public void TestABSMinusOnePointTwo()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            WinComboBox uIItemComboBox = this.UIGraphCalcWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(415, 192));

            // Select 'abs(-1.2)' in combo box
            uIItemComboBox.EditableItem = this.TestABSMinusOnePointTwoParams.UIItemComboBoxEditableItem;

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(606, 414));
        }
        
        /// <summary>
        /// TEST ABS(-30), expect 30
        /// </summary>
        public void TestABSMinusThirty()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            WinComboBox uIItemComboBox = this.UIGraphCalcWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(416, 192));

            // Select 'abs(-30)' in combo box
            uIItemComboBox.EditableItem = this.TestABSMinusThirtyParams.UIItemComboBoxEditableItem;

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(600, 411));
        }
        
        /// <summary>
        /// Test ABS(1), expect 1
        /// </summary>
        public void TestABSOne()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            WinComboBox uIItemComboBox = this.UIGraphCalcWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(416, 187));

            // Select 'abs(1)' in combo box
            uIItemComboBox.EditableItem = this.TestABSOneParams.UIItemComboBoxEditableItem;

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(594, 409));
        }
        
        /// <summary>
        /// Test ABS(1/4), expect 0.25
        /// </summary>
        public void TestABSOnefourth()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            WinComboBox uIItemComboBox = this.UIGraphCalcWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(413, 189));

            // Select 'abs(1/4)' in combo box
            uIItemComboBox.EditableItem = this.TestABSOnefourthParams.UIItemComboBoxEditableItem;

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(605, 404));
        }
        
        /// <summary>
        /// Test ABS(1,000,000), expect 1,000,000
        /// </summary>
        public void TestABSOneMillion()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(409, 187));

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(461, 374));

            // Double-Click 'GraphCalc' Dialog
            Mouse.DoubleClick(uIGraphCalcDialog, new Point(461, 402));

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(461, 402));

            // Double-Click 'GraphCalc' Dialog
            Mouse.DoubleClick(uIGraphCalcDialog, new Point(461, 402));

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(461, 402));

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(597, 400));
        }
        
        /// <summary>
        /// Test ABS(1.2), expect 1.2
        /// </summary>
        public void TestABSOnePointTwo()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            WinComboBox uIItemComboBox = this.UIGraphCalcWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(413, 193));

            // Select 'abs(1.2)' in combo box
            uIItemComboBox.EditableItem = this.TestABSOnePointTwoParams.UIItemComboBoxEditableItem;

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(589, 407));
        }
        
        /// <summary>
        /// TEST ABS(30), expect 30
        /// </summary>
        public void TestABSThirty()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(406, 189));

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(556, 376));

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(469, 408));

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(602, 410));
        }
        
        /// <summary>
        /// TEST ABS(0), expect 0
        /// </summary>
        public void TestABSZero()
        {
            #region Variable Declarations
            WinControl uIGraphCalcDialog = this.UIGraphCalcWindow.UIGraphCalcDialog;
            #endregion

            // The recording for the application under test '\\Mac\Home\Downloads\GraphCalc\GrphCalc.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(415, 193));

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(465, 409));

            // Click 'GraphCalc' Dialog
            Mouse.Click(uIGraphCalcDialog, new Point(602, 409));
        }
        
        #region Properties
        public virtual TestABSMinusOneParams TestABSMinusOneParams
        {
            get
            {
                if ((this.mTestABSMinusOneParams == null))
                {
                    this.mTestABSMinusOneParams = new TestABSMinusOneParams();
                }
                return this.mTestABSMinusOneParams;
            }
        }
        
        public virtual TestABSMinusOnefourthParams TestABSMinusOnefourthParams
        {
            get
            {
                if ((this.mTestABSMinusOnefourthParams == null))
                {
                    this.mTestABSMinusOnefourthParams = new TestABSMinusOnefourthParams();
                }
                return this.mTestABSMinusOnefourthParams;
            }
        }
        
        public virtual TestABSMinusOneMillionParams TestABSMinusOneMillionParams
        {
            get
            {
                if ((this.mTestABSMinusOneMillionParams == null))
                {
                    this.mTestABSMinusOneMillionParams = new TestABSMinusOneMillionParams();
                }
                return this.mTestABSMinusOneMillionParams;
            }
        }
        
        public virtual TestABSMinusOneMinusThreeParams TestABSMinusOneMinusThreeParams
        {
            get
            {
                if ((this.mTestABSMinusOneMinusThreeParams == null))
                {
                    this.mTestABSMinusOneMinusThreeParams = new TestABSMinusOneMinusThreeParams();
                }
                return this.mTestABSMinusOneMinusThreeParams;
            }
        }
        
        public virtual TestABSMinusOnePointTwoParams TestABSMinusOnePointTwoParams
        {
            get
            {
                if ((this.mTestABSMinusOnePointTwoParams == null))
                {
                    this.mTestABSMinusOnePointTwoParams = new TestABSMinusOnePointTwoParams();
                }
                return this.mTestABSMinusOnePointTwoParams;
            }
        }
        
        public virtual TestABSMinusThirtyParams TestABSMinusThirtyParams
        {
            get
            {
                if ((this.mTestABSMinusThirtyParams == null))
                {
                    this.mTestABSMinusThirtyParams = new TestABSMinusThirtyParams();
                }
                return this.mTestABSMinusThirtyParams;
            }
        }
        
        public virtual TestABSOneParams TestABSOneParams
        {
            get
            {
                if ((this.mTestABSOneParams == null))
                {
                    this.mTestABSOneParams = new TestABSOneParams();
                }
                return this.mTestABSOneParams;
            }
        }
        
        public virtual TestABSOnefourthParams TestABSOnefourthParams
        {
            get
            {
                if ((this.mTestABSOnefourthParams == null))
                {
                    this.mTestABSOnefourthParams = new TestABSOnefourthParams();
                }
                return this.mTestABSOnefourthParams;
            }
        }
        
        public virtual TestABSOnePointTwoParams TestABSOnePointTwoParams
        {
            get
            {
                if ((this.mTestABSOnePointTwoParams == null))
                {
                    this.mTestABSOnePointTwoParams = new TestABSOnePointTwoParams();
                }
                return this.mTestABSOnePointTwoParams;
            }
        }
        
        public UIGraphCalcWindow UIGraphCalcWindow
        {
            get
            {
                if ((this.mUIGraphCalcWindow == null))
                {
                    this.mUIGraphCalcWindow = new UIGraphCalcWindow();
                }
                return this.mUIGraphCalcWindow;
            }
        }
        #endregion
        
        #region Fields
        private TestABSMinusOneParams mTestABSMinusOneParams;
        
        private TestABSMinusOnefourthParams mTestABSMinusOnefourthParams;
        
        private TestABSMinusOneMillionParams mTestABSMinusOneMillionParams;
        
        private TestABSMinusOneMinusThreeParams mTestABSMinusOneMinusThreeParams;
        
        private TestABSMinusOnePointTwoParams mTestABSMinusOnePointTwoParams;
        
        private TestABSMinusThirtyParams mTestABSMinusThirtyParams;
        
        private TestABSOneParams mTestABSOneParams;
        
        private TestABSOnefourthParams mTestABSOnefourthParams;
        
        private TestABSOnePointTwoParams mTestABSOnePointTwoParams;
        
        private UIGraphCalcWindow mUIGraphCalcWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TestABSMinusOne'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TestABSMinusOneParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'abs(-1)' in combo box
        /// </summary>
        public string UIItemComboBoxEditableItem = "abs(-1)";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TestABSMinusOnefourth'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TestABSMinusOnefourthParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'abs(-(1/4))' in combo box
        /// </summary>
        public string UIItemComboBoxEditableItem = "abs(-(1/4))";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TestABSMinusOneMillion'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TestABSMinusOneMillionParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'abs(-1000000)' in combo box
        /// </summary>
        public string UIItemComboBoxEditableItem = "abs(-1000000)";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TestABSMinusOneMinusThree'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TestABSMinusOneMinusThreeParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'abs(-1-3)' in combo box
        /// </summary>
        public string UIItemComboBoxEditableItem = "abs(-1-3)";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TestABSMinusOnePointTwo'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TestABSMinusOnePointTwoParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'abs(-1.2)' in combo box
        /// </summary>
        public string UIItemComboBoxEditableItem = "abs(-1.2)";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TestABSMinusThirty'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TestABSMinusThirtyParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'abs(-30)' in combo box
        /// </summary>
        public string UIItemComboBoxEditableItem = "abs(-30)";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TestABSOne'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TestABSOneParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'abs(1)' in combo box
        /// </summary>
        public string UIItemComboBoxEditableItem = "abs(1)";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TestABSOnefourth'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TestABSOnefourthParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'abs(1/4)' in combo box
        /// </summary>
        public string UIItemComboBoxEditableItem = "abs(1/4)";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TestABSOnePointTwo'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TestABSOnePointTwoParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'abs(1.2)' in combo box
        /// </summary>
        public string UIItemComboBoxEditableItem = "abs(1.2)";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIGraphCalcWindow : WinWindow
    {
        
        public UIGraphCalcWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "GraphCalc";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("GraphCalc");
            #endregion
        }
        
        #region Properties
        public WinControl UIGraphCalcDialog
        {
            get
            {
                if ((this.mUIGraphCalcDialog == null))
                {
                    this.mUIGraphCalcDialog = new WinControl(this);
                    #region Search Criteria
                    this.mUIGraphCalcDialog.SearchProperties[UITestControl.PropertyNames.Name] = "GraphCalc";
                    this.mUIGraphCalcDialog.SearchProperties[UITestControl.PropertyNames.ControlType] = "Dialog";
                    this.mUIGraphCalcDialog.WindowTitles.Add("GraphCalc");
                    #endregion
                }
                return this.mUIGraphCalcDialog;
            }
        }
        
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        #endregion
        
        #region Fields
        private WinControl mUIGraphCalcDialog;
        
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1001";
            this.WindowTitles.Add("GraphCalc");
            #endregion
        }
        
        #region Properties
        public WinComboBox UIItemComboBox
        {
            get
            {
                if ((this.mUIItemComboBox == null))
                {
                    this.mUIItemComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIItemComboBox.WindowTitles.Add("GraphCalc");
                    #endregion
                }
                return this.mUIItemComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUIItemComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1003";
            this.WindowTitles.Add("GraphCalc");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.WindowTitles.Add("GraphCalc");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
}
