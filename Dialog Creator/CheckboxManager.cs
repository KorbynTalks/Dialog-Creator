using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dialog_Creator
{
    /*

    -------------------
    |                 |
    | CheckboxManager |
    |                 |
    -------------------

    When Checkboxes are put into this script through putting in the Checkboxes you want in a List. This script will make sure one of those checkboxes in said List is
    Checked and nothing else.

    Potentially early asf code, I dont like how I have to create a seperate method for each List of Checkboxes.

    */


    public class CheckboxManager
    {
        public List<CheckBox> checkBoxesBasicDialog = new List<CheckBox>();

        public List<CheckBox> checkBoxesIcons = new List<CheckBox>();

        public List<CheckBox> checkBoxesTaskDialogButton1 = new List<CheckBox>();

        public List<CheckBox> checkBoxesTaskDialogButton2 = new List<CheckBox>();

        public List<CheckBox> checkBoxesTaskDialogButton3 = new List<CheckBox>();

        public List<CheckBox> checkBoxesTaskDialogButton4 = new List<CheckBox>();

        public void CheckboxManage()
        {
            foreach (CheckBox checkBoxesinList in checkBoxesBasicDialog)
            {
                checkBoxesinList.CheckedChanged += CheckBoxesinList_CheckedChanged;
            }

            foreach (CheckBox checkBoxesinList in checkBoxesIcons)
            {
                checkBoxesinList.CheckedChanged += CheckBoxesinListIcons_CheckedChanged;
            }

            foreach (CheckBox checkBoxesinList in checkBoxesTaskDialogButton1)
            {
                checkBoxesinList.CheckedChanged += CheckBoxesinListTDB1_CheckedChanged;
            }

            foreach (CheckBox checkBoxesinList in checkBoxesTaskDialogButton2)
            {
                checkBoxesinList.CheckedChanged += CheckBoxesinListTDB2_CheckedChanged;
            }

            foreach (CheckBox checkBoxesinList in checkBoxesTaskDialogButton3)
            {
                checkBoxesinList.CheckedChanged += CheckBoxesinListTDB3_CheckedChanged;
            }

            foreach (CheckBox checkBoxesinList in checkBoxesTaskDialogButton4)
            {
                checkBoxesinList.CheckedChanged += CheckBoxesinListTDB4_CheckedChanged;
            }
        }

        private void CheckBoxesinListTDB4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox current = sender as CheckBox;

            if (current.Checked)
            {
                foreach (CheckBox cb in checkBoxesTaskDialogButton4)
                {
                    if (cb != current)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }

        private void CheckBoxesinListTDB3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox current = sender as CheckBox;

            if (current.Checked)
            {
                foreach (CheckBox cb in checkBoxesTaskDialogButton3)
                {
                    if (cb != current)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }

        private void CheckBoxesinListTDB2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox current = sender as CheckBox;

            if (current.Checked)
            {
                foreach (CheckBox cb in checkBoxesTaskDialogButton2)
                {
                    if (cb != current)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }

        private void CheckBoxesinListTDB1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox current = sender as CheckBox;

            if (current.Checked)
            {
                foreach (CheckBox cb in checkBoxesTaskDialogButton1)
                {
                    if (cb != current)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }

        private void CheckBoxesinListIcons_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox current = sender as CheckBox;

            if (current.Checked)
            {
                foreach (CheckBox cb in checkBoxesIcons)
                {
                    if (cb != current)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }

        private void CheckBoxesinList_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox current = sender as CheckBox;

            if (current.Checked)
            {
                foreach (CheckBox cb in checkBoxesBasicDialog)
                {
                    if (cb != current)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }
    }
}
