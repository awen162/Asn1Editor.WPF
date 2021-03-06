﻿using System;
using System.Collections.Generic;
using SysadminsLV.Asn1Editor.API.ModelObjects;
using SysadminsLV.Asn1Editor.API.Utils;

namespace SysadminsLV.Asn1Editor.API.Interfaces {
    interface IWindowFactory {
        void ShowLicenseDialog();
        void ShowSettingsDialog();
        void ShowAboutDialog();
        Asn1Lite ShowNodeContentEditor(NodeEditMode editMode);
        void ShowNodeTextViewer();
        void ShowConverterWindow(IEnumerable<Byte> data, Action<Byte[]> action);
    }
}
