﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Resources;
using WizardFramework;

namespace Ankh.UI.MergeWizard
{
    /// <summary>
    /// Implementation of a wizard page for retrieving the merge source
    /// information for your typical merge scenario.
    /// </summary>
    class MergeSourceRangeOfRevisionsPage : WizardPage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MergeSourceRangeOfRevisionsPage() : base("Merge Source Range Of Revisions")
        {
            IsPageComplete = false;
            Title = Resources.MergeSourceHeaderTitle;
            Description = Resources.MergeSourceRangeOfRevisionsPageHeaderMessage;
        }

        /// <see cref="WizardFramework.IWizardPage.Control" />
        public override System.Windows.Forms.UserControl Control
        {
            get { return control_prop; }
        }

        private MergeSourceRangeOfRevisionsPageControl control_prop = new MergeSourceRangeOfRevisionsPageControl();
    }
}
