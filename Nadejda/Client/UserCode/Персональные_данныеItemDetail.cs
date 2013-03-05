using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class Персональные_данныеItemDetail
    {
        partial void Персональные_данныеItem_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Персональные_данныеItem);
        }

        partial void Персональные_данныеItem_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Персональные_данныеItem);
        }

        partial void Персональные_данныеItemDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Персональные_данныеItem);
        }
    }
}