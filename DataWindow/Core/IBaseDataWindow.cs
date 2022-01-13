﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;
using DataWindow.DesignLayer;
using DataWindow.Serialization.Components;

namespace DataWindow.Core
{
    public interface IBaseDataWindow
    {
        Designer GetDesigner();
        DefaultDesignerLoader GetDefaultDesignerLoader();

        void SetDefaultLayoutXml(string xml);
        string GetDefaultLayoutXml();

        void SetLayoutXml(string xml);
        string GetLayoutXml();

        List<Control> GetInherentControls();
        void AddInherentControls();
        void AddInherentControls(Control[] controls);
        bool IsInherentControl(Control con);
        Control GetInherentControl(string name);


        List<Control> GetMustEditControls();
        bool IsMustControl(Control control);
        bool IsMustControl(string name);

        List<Control> GetProhibitEditControls();
        bool IsProhibitEditControl(Control con);
        bool IsProhibitEditControl(string name);

        Dictionary<Control, string> GetControlTranslation();
    }
}