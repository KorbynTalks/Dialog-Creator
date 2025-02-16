using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Dialog_Creator
{
    public partial class Form1 : Form
    {
        private MessageBoxButtons classicMessageBoxButton;
        private MessageBoxIcon classicMessageBoxIcon;

        private DialogResult classicMessageBoxRequiredButtonToClickToPerformAction;
        private DialogResult classicMessageBoxRequiredButton2ToClickToPerformAction;
        private DialogResult classicMessageBoxRequiredButton3ToClickToPerformAction;

        private TaskDialogStandardButtons Standardbutton1;
        private TaskDialogStandardButtons Standardbutton2;
        private TaskDialogStandardButtons Standardbutton3;
        private TaskDialogStandardButtons Standardbutton4;

        private TaskDialogStandardIcon Standardicon;
        private TaskDialogStandardIcon footerIcon;

        private TaskDialogExpandedDetailsLocation expandedDetailsLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogTypeDropdown.SelectedItem = "Basic Dialog Box (Classic Error Message)"; // Set the Dropdown to the Classic Dialog Box option
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // When the Create button is clicked, it will check what Button Checkbox is selected then changes MessageBoxButtons variable classicMessageBoxButton to the specified Buttons.
            if (OKCheckbox.Checked)
            {
                classicMessageBoxButton = MessageBoxButtons.OK;
                classicMessageBoxRequiredButtonToClickToPerformAction = DialogResult.OK;
            } else if(yesNoCheckbox.Checked)
            {
                classicMessageBoxButton = MessageBoxButtons.YesNo;
                classicMessageBoxRequiredButtonToClickToPerformAction = DialogResult.Yes;
                classicMessageBoxRequiredButton2ToClickToPerformAction = DialogResult.No;
            } else if(yesNoCancelCheckbox.Checked)
            {
                classicMessageBoxButton = MessageBoxButtons.YesNoCancel;
                classicMessageBoxRequiredButtonToClickToPerformAction = DialogResult.Yes;
                classicMessageBoxRequiredButton2ToClickToPerformAction = DialogResult.No;
                classicMessageBoxRequiredButton3ToClickToPerformAction = DialogResult.Cancel;
            } else if(OKCancelCheckbox.Checked)
            {
                classicMessageBoxButton = MessageBoxButtons.OKCancel;
                classicMessageBoxRequiredButtonToClickToPerformAction = DialogResult.OK;
                classicMessageBoxRequiredButton2ToClickToPerformAction = DialogResult.Cancel;
            } else if(abortRetryIgnoreCheckbox.Checked)
            {
                classicMessageBoxButton = MessageBoxButtons.AbortRetryIgnore;
                classicMessageBoxRequiredButtonToClickToPerformAction = DialogResult.Abort;
                classicMessageBoxRequiredButton2ToClickToPerformAction = DialogResult.Retry;
                classicMessageBoxRequiredButton3ToClickToPerformAction = DialogResult.Ignore;
            } else if(retryCancelCheckbox.Checked)
            {
                classicMessageBoxButton = MessageBoxButtons.RetryCancel;
                classicMessageBoxRequiredButtonToClickToPerformAction = DialogResult.Retry;
                classicMessageBoxRequiredButton2ToClickToPerformAction = DialogResult.Cancel;
            } else if(noneCheckbox.Checked)
            {
                classicMessageBoxButton = MessageBoxButtons.OK;
                classicMessageBoxRequiredButtonToClickToPerformAction = DialogResult.OK;
            } else
            {
                classicMessageBoxButton = MessageBoxButtons.OK;
                classicMessageBoxRequiredButtonToClickToPerformAction = DialogResult.OK;
            }

            if(button1OKCheckbox.Checked)
            {
                Standardbutton1 = TaskDialogStandardButtons.Ok;
            } else if(button1YesCheckbox.Checked)
            {
                Standardbutton1 = TaskDialogStandardButtons.Yes;
            } else if(button1NoCheckbox.Checked)
            {
                Standardbutton1 = TaskDialogStandardButtons.No;
            } else if(button1CancelCheckbox.Checked)
            {
                Standardbutton1 = TaskDialogStandardButtons.Cancel;
            } else if(button1CloseCheckbox.Checked)
            {
                Standardbutton1 = TaskDialogStandardButtons.Close;
            } else if(button1RetryCheckbox.Checked)
            {
                Standardbutton1 = TaskDialogStandardButtons.Retry;
            } else if(button1NoneCheckbox.Checked)
            {
                Standardbutton1 = TaskDialogStandardButtons.None;
            } else
            {
                Standardbutton1 = TaskDialogStandardButtons.None;
            }

            if(button2OKCheckbox.Checked)
            {
                Standardbutton2 = TaskDialogStandardButtons.Ok;
            } else if(button2YesCheckbox.Checked)
            {
                Standardbutton2 = TaskDialogStandardButtons.Yes;
            } else if(button2NoCheckbox.Checked)
            {
                Standardbutton2 = TaskDialogStandardButtons.No;
            } else if(button2CancelCheckbox.Checked)
            {
                Standardbutton2 = TaskDialogStandardButtons.Cancel;
            } else if(button2CloseCheckbox.Checked)
            {
                Standardbutton2 = TaskDialogStandardButtons.Close;
            } else if(button2RetryCheckbox.Checked)
            {
                Standardbutton2 = TaskDialogStandardButtons.Retry;
            } else if(button2NoneCheckbox.Checked)
            {
                Standardbutton2 = TaskDialogStandardButtons.None;
            } else
            {
                Standardbutton2 = TaskDialogStandardButtons.None;
            }

            if (button3OKCheckbox.Checked)
            {
                Standardbutton3 = TaskDialogStandardButtons.Ok;
            }
            else if (button3YesCheckbox.Checked)
            {
                Standardbutton3 = TaskDialogStandardButtons.Yes;
            }
            else if (button3NoCheckbox.Checked)
            {
                Standardbutton3 = TaskDialogStandardButtons.No;
            }
            else if (button3CancelCheckbox.Checked)
            {
                Standardbutton3 = TaskDialogStandardButtons.Cancel;
            }
            else if (button3CloseCheckbox.Checked)
            {
                Standardbutton3 = TaskDialogStandardButtons.Close;
            }
            else if (button3RetryCheckbox.Checked)
            {
                Standardbutton3 = TaskDialogStandardButtons.Retry;
            }
            else if (button3NoneCheckbox.Checked)
            {
                Standardbutton3 = TaskDialogStandardButtons.None;
            }
            else
            {
                Standardbutton3 = TaskDialogStandardButtons.None;
            }

            if (button4OKCheckbox.Checked)
            {
                Standardbutton4 = TaskDialogStandardButtons.Ok;
            }
            else if (button4YesCheckbox.Checked)
            {
                Standardbutton4 = TaskDialogStandardButtons.Yes;
            }
            else if (button4NoCheckbox.Checked)
            {
                Standardbutton4 = TaskDialogStandardButtons.No;
            }
            else if (button4CancelCheckbox.Checked)
            {
                Standardbutton4 = TaskDialogStandardButtons.Cancel;
            }
            else if (button4CloseCheckbox.Checked)
            {
                Standardbutton4 = TaskDialogStandardButtons.Close;
            }
            else if (button4RetryCheckbox.Checked)
            {
                Standardbutton4 = TaskDialogStandardButtons.Retry;
            }
            else if (button4NoneCheckbox.Checked)
            {
                Standardbutton4 = TaskDialogStandardButtons.None;
            }
            else
            {
                Standardbutton4 = TaskDialogStandardButtons.None;
            }

            // Similar to the Buttons, but instead for Icons, basically.
            if (errorCheckbox.Checked)
            {
                classicMessageBoxIcon = MessageBoxIcon.Error;
                Standardicon = TaskDialogStandardIcon.Error;
            } else if(informationCheckbox.Checked)
            {
                classicMessageBoxIcon = MessageBoxIcon.Information;
                Standardicon = TaskDialogStandardIcon.Information;
            } else if(warningCheckbox.Checked)
            {
                classicMessageBoxIcon = MessageBoxIcon.Warning;
                Standardicon = TaskDialogStandardIcon.Warning;
            } else if(questionCheckbox.Checked)
            {
                classicMessageBoxIcon = MessageBoxIcon.Question;
                Standardicon = TaskDialogStandardIcon.Shield;
            } else if(noIconCheckbox.Checked)
            {
                classicMessageBoxIcon = MessageBoxIcon.None;
                Standardicon = TaskDialogStandardIcon.None;
            }

            if(footerIconError.Checked)
            {
                footerIcon = TaskDialogStandardIcon.Error;
            } else if(footerIconInfo.Checked)
            {
                footerIcon = TaskDialogStandardIcon.Information;
            } else if(footerIconWarning.Checked)
            {
                footerIcon = TaskDialogStandardIcon.Warning;
            } else if(footerIconQuestion.Checked)
            {
                footerIcon = TaskDialogStandardIcon.Shield;
            } else if(footerIconNone.Checked)
            {
                footerIcon = TaskDialogStandardIcon.None;
            }

            if(expmdeShowFooterCheckbox.Checked)
            {
                expandedDetailsLocation = TaskDialogExpandedDetailsLocation.ExpandFooter;
            } else if(expmdeShowContentCheckbox.Checked)
            {
                expandedDetailsLocation = TaskDialogExpandedDetailsLocation.ExpandContent;
            } else if(expmdeHideCheckbox.Checked)
            {
                expandedDetailsLocation = TaskDialogExpandedDetailsLocation.Hide;
            }

            // Classic Dialog Box
            if (DialogTypeDropdown.SelectedItem.ToString() == "Basic Dialog Box (Classic Error Message)")
            {
                DialogResult classicMessageBox;
                classicMessageBox = MessageBox.Show(messageTextTextBox.Text, titlebarTextTextBox.Text, classicMessageBoxButton, classicMessageBoxIcon);
                if(classicMessageBox == classicMessageBoxRequiredButtonToClickToPerformAction)
                {
                    if(websiteLinkTextBox.Text.Contains("https://"))
                    {
                        Process.Start(websiteLinkTextBox.Text);
                    } else if(commandTextBox.Text.Length > 0)
                    {
                        Process.Start("cmd.exe", "/c" + commandTextBox.Text);
                    }
                    
                } else if(classicMessageBox == classicMessageBoxRequiredButton2ToClickToPerformAction)
                {
                    if (websiteLinkTextBox2.Text.Contains("https://"))
                    {
                        Process.Start(websiteLinkTextBox2.Text);
                    }
                    else if (commandTextBox2.Text.Length > 0)
                    {
                        Process.Start("cmd.exe", "/c" + commandTextBox2.Text);
                    }
                } else if(classicMessageBox == classicMessageBoxRequiredButton3ToClickToPerformAction)
                {
                    if (websiteLinkTextBox3.Text.Contains("https://"))
                    {
                        Process.Start(websiteLinkTextBox3.Text);
                    }
                    else if (commandTextBox3.Text.Length > 0)
                    {
                        Process.Start("cmd.exe", "/c" + commandTextBox3.Text);
                    }
                }
            } else if(DialogTypeDropdown.SelectedItem.ToString() == "Task Dialog Box (More Advanced, and more customizable. Links Version)") // Task Dialog Links
            {
                TaskDialogBoxLinks(
                    instTextTextBox.Text, 
                    expandTextTextBox.Text, 
                    titlebarTextTextBox.Text, 
                    linkTextBox.Text, 
                    linkText1TextBox.Text, 
                    linkText2TextBox.Text, 
                    elevatedIconCheckbox.Checked, 
                    Standardbutton1, 
                    Standardbutton2, 
                    Standardbutton3,
                    Standardbutton4,
                    Standardicon,
                    expandedDetailsLocation,
                    cancelableCheckbox.Checked,
                    collapsedSeeDetailsTextBox.Text,
                    extendedSeeDetailsTextBox.Text,
                    footerCheckBoxTextBox.Text,
                    footerTextBox.Text,
                    footerIcon,
                    linkTextBox.Text,
                    commandTaskDialogLinkTextBox.Text,
                    messageTextTextBox.Text
                );
            } else if(DialogTypeDropdown.SelectedItem.ToString() == "Task Dialog Box (More Advanced, and more customizable. Custom Buttons Version)") // Task Dialog Custom Buttons
            {
                TaskDialogBoxCustomButtons(
                    instTextTextBox.Text,
                    expandTextTextBox.Text,
                    titlebarTextTextBox.Text,
                    Standardicon,
                    customButtonTextTextBox.Text,
                    elevatedIconCheckbox.Checked,
                    expandedDetailsLocation,
                    cancelableCheckbox.Checked,
                    collapsedSeeDetailsTextBox.Text,
                    extendedSeeDetailsTextBox.Text,
                    footerCheckBoxTextBox.Text,
                    footerTextBox.Text,
                    footerIcon,
                    linkTaskDialogCustomButtonTextBox.Text,
                    commandTaskDialogCustomButtonTextBox.Text,
                    messageTextTextBox.Text
                );
            } else if(DialogTypeDropdown.SelectedItem.ToString() == "Task Dialog Box (More Advanced, and more customizable.)")
            {
                TaskDialogBox(
                   instTextTextBox.Text,
                   expandTextTextBox.Text,
                   titlebarTextTextBox.Text,
                   Standardicon,
                   expandedDetailsLocation,
                   cancelableCheckbox.Checked,
                   collapsedSeeDetailsTextBox.Text,
                   extendedSeeDetailsTextBox.Text,
                   footerCheckBoxTextBox.Text,
                   footerTextBox.Text,
                   footerIcon,
                   messageTextTextBox.Text,
                   Standardbutton1,
                   Standardbutton2,
                   Standardbutton3,
                   Standardbutton4
                );
            }
        }
        // Task Dialog Links Code
        public static void TaskDialogBoxLinks(
            string instructionText, 
            string expandedText, 
            string caption, 
            string Link, 
            string linkText, 
            string linkText2, 
            bool useLinkIcon, 
            TaskDialogStandardButtons stanButton1, 
            TaskDialogStandardButtons stanButton2, 
            TaskDialogStandardButtons stanButton3, 
            TaskDialogStandardButtons stanButton4,
            TaskDialogStandardIcon stanIcon,
            TaskDialogExpandedDetailsLocation expandMode,
            bool cancelable,
            string collapsedLabel,
            string expandedLabel,
            string footerCheckboxLabel,
            string footerLabel,
            TaskDialogStandardIcon footerIcon,
            string linkTextBox,
            string commandTextBox,
            string messageText
        )
        {

            if(Link.Contains("https://"))
            {

            } else
            {
                Link = "C:/Windows/System32/cmd.exe";
            }

            TaskDialogCommandLink link = null;
            TaskDialog dia = new TaskDialog();

            if (stanButton1 == TaskDialogStandardButtons.None && stanButton2 == TaskDialogStandardButtons.None && stanButton3 == TaskDialogStandardButtons.None && dia.Cancelable == false)
            {
                cancelable = true;
            }

            link = new TaskDialogCommandLink(Link, linkText, linkText2);
            link.UseElevationIcon = useLinkIcon;
            link.Enabled = true;
            link.Click += new EventHandler(link_Click);

            void link_Click(object sender, EventArgs e)
            {
                if(linkTextBox.Contains("https://"))
                {
                    Process.Start(link.Name);
                    dia.Close();
                } else if(commandTextBox.Length > 0)
                {
                    Process.Start("cmd.exe", "/c"+commandTextBox);
                    dia.Close();
                }
                
            }

            dia.Cancelable = cancelable;
            dia.InstructionText = instructionText;
            dia.StandardButtons = stanButton1 | stanButton2 | stanButton3 | stanButton4;
            dia.DetailsExpanded = false;
            dia.DetailsExpandedText = expandedText;
            dia.ExpansionMode = expandMode;
            dia.Caption = caption;
            dia.Text = messageText;
            dia.Icon = stanIcon;
            dia.Controls.Add(link);
            dia.DetailsCollapsedLabel = collapsedLabel;
            dia.DetailsExpandedLabel = expandedLabel;
            dia.FooterCheckBoxText = footerCheckboxLabel;
            dia.FooterText = footerLabel;
            dia.FooterIcon = footerIcon;
            dia.Show();
        }
        // Task Dialog Custom Buttons
        public static void TaskDialogBoxCustomButtons(
            string instructionText, 
            string expandedText, 
            string caption, 
            TaskDialogStandardIcon stanIcon, 
            string customButtonText, 
            bool useElevButtonIcon,
            TaskDialogExpandedDetailsLocation expandMode,
            bool cancelable,
            string collapsedLabel,
            string expandedLabel,
            string footerCheckboxLabel,
            string footerLabel,
            TaskDialogStandardIcon footerIcon,
            string linkTextBox,
            string commandTextBox,
            string messageText
        )
        {
            TaskDialogButton customButton = new TaskDialogButton("customButton1", customButtonText);
            TaskDialog dia = new TaskDialog();

            customButton.UseElevationIcon = useElevButtonIcon;
            customButton.Enabled = true;
            customButton.Click += new EventHandler(buttonClick);

            void buttonClick(object sender, EventArgs e)
            {
                if(linkTextBox.Length == 0 && commandTextBox.Length == 0)
                {
                    dia.Close();
                } else if(linkTextBox.Contains("https://"))
                {
                    Process.Start(linkTextBox);
                    dia.Close();
                } else if(commandTextBox.Length > 0)
                {
                    Process.Start("cmd.exe", "/c" + commandTextBox);
                    dia.Close();
                }
                
            }

            dia.Cancelable = cancelable;
            dia.InstructionText = instructionText;
            dia.DetailsExpanded = false;
            dia.DetailsExpandedText = expandedText;
            dia.ExpansionMode = expandMode;
            dia.Caption = caption;
            dia.Text = messageText;
            dia.Icon = stanIcon;
            dia.Controls.Add(customButton);
            dia.DetailsCollapsedLabel = collapsedLabel;
            dia.DetailsExpandedLabel = expandedLabel;
            dia.FooterCheckBoxText = footerCheckboxLabel;
            dia.FooterText = footerLabel;
            dia.FooterIcon = footerIcon;
            dia.Show();
        }
        // Task Dialog Box
        public static void TaskDialogBox(
            string instructionText,
            string expandedText,
            string caption,
            TaskDialogStandardIcon stanIcon,
            TaskDialogExpandedDetailsLocation expandMode,
            bool cancelable,
            string collapsedLabel,
            string expandedLabel,
            string footerCheckboxLabel,
            string footerLabel,
            TaskDialogStandardIcon footerIcon,
            string messageText,
            TaskDialogStandardButtons stanButton1,
            TaskDialogStandardButtons stanButton2,
            TaskDialogStandardButtons stanButton3,
            TaskDialogStandardButtons stanButton4
        )
        {
            TaskDialog dia = new TaskDialog();

            dia.Cancelable = cancelable;
            dia.InstructionText = instructionText;
            dia.DetailsExpanded = false;
            dia.DetailsExpandedText = expandedText;
            dia.StandardButtons = stanButton1 | stanButton2 | stanButton3 | stanButton4;
            dia.ExpansionMode = expandMode;
            dia.Caption = caption;
            dia.Text = messageText;
            dia.Icon = stanIcon;
            dia.DetailsCollapsedLabel = collapsedLabel;
            dia.DetailsExpandedLabel = expandedLabel;
            dia.FooterCheckBoxText = footerCheckboxLabel;
            dia.FooterText = footerLabel;
            dia.FooterIcon = footerIcon;
            dia.Show();
        }

        private void DialogTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DialogTypeDropdown.SelectedItem.ToString() == "Basic Dialog Box (Classic Error Message)")
            {
                taskDialogGroup.Enabled = false;
                customButtonTextTextBox.Enabled = false;
                linkTextBox.Enabled = false;
                linkText1TextBox.Enabled = false;
                linkText2TextBox.Enabled = false;
                basicDialogGroup.Enabled = true;
            } else if(DialogTypeDropdown.SelectedItem.ToString() == "Task Dialog Box (More Advanced, and more customizable. Links Version)")
            {
                taskDialogGroup.Enabled = true;
                customButtonTextTextBox.Enabled = false;
                linkTextBox.Enabled = true;
                linkText1TextBox.Enabled = true;
                linkText2TextBox.Enabled = true;
                commandTaskDialogLinkTextBox.Enabled = true;
                button1Group.Enabled = true;
                button2Group.Enabled = true;
                button3Group.Enabled = true;
                button4Group.Enabled = true;
                basicDialogGroup.Enabled = false;
                linkTaskDialogCustomButtonTextBox.Enabled = false;
                commandTaskDialogCustomButtonTextBox.Enabled = false;
                elevatedIconCheckbox.Enabled = true;
            } else if(DialogTypeDropdown.SelectedItem.ToString() == "Task Dialog Box (More Advanced, and more customizable. Custom Buttons Version)")
            {
                taskDialogGroup.Enabled = true;
                customButtonTextTextBox.Enabled = true;
                commandTaskDialogCustomButtonTextBox.Enabled = true;
                linkTaskDialogCustomButtonTextBox.Enabled = true;
                linkTextBox.Enabled = false;
                linkText1TextBox.Enabled = false;
                linkText2TextBox.Enabled = false;
                basicDialogGroup.Enabled = false;
                commandTaskDialogLinkTextBox.Enabled = false;
                button1Group.Enabled = false;
                button2Group.Enabled = false;
                button3Group.Enabled = false;
                button4Group.Enabled = false;
                elevatedIconCheckbox.Enabled = true;
            } else if(DialogTypeDropdown.SelectedItem.ToString() == "Task Dialog Box (More Advanced, and more customizable.)")
            {
                taskDialogGroup.Enabled = true;
                customButtonTextTextBox.Enabled = false;
                commandTaskDialogCustomButtonTextBox.Enabled = false;
                linkTaskDialogCustomButtonTextBox.Enabled = false;
                linkTextBox.Enabled = false;
                linkText1TextBox.Enabled = false;
                linkText2TextBox.Enabled = false;
                basicDialogGroup.Enabled = false;
                commandTaskDialogLinkTextBox.Enabled = false;
                button1Group.Enabled = true;
                button2Group.Enabled = true;
                button3Group.Enabled = true;
                button4Group.Enabled = true;
                elevatedIconCheckbox.Enabled = false;
            }
        }

        // These are checks if 1 box is checked while another is also checked, this is so only 1 can be checked.
        private void OKCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(OKCheckbox.Checked == true)
            {
                yesNoCheckbox.Checked = false;
                yesNoCancelCheckbox.Checked = false;
                OKCancelCheckbox.Checked = false;
                abortRetryIgnoreCheckbox.Checked = false;
                retryCancelCheckbox.Checked = false;
                noneCheckbox.Checked = false;
            }
            
        }

        private void yesNoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (yesNoCheckbox.Checked == true)
            {
                OKCheckbox.Checked = false;
                yesNoCancelCheckbox.Checked = false;
                OKCancelCheckbox.Checked = false;
                abortRetryIgnoreCheckbox.Checked = false;
                retryCancelCheckbox.Checked = false;
                noneCheckbox.Checked = false;
            }
        }

        private void yesNoCancelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (yesNoCancelCheckbox.Checked == true)
            {
                yesNoCheckbox.Checked = false;
                OKCheckbox.Checked = false;
                OKCancelCheckbox.Checked = false;
                abortRetryIgnoreCheckbox.Checked = false;
                retryCancelCheckbox.Checked = false;
                noneCheckbox.Checked = false;
            }
        }

        private void OKCancelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (OKCancelCheckbox.Checked == true)
            {
                OKCheckbox.Checked = false;
                yesNoCancelCheckbox.Checked = false;
                yesNoCheckbox.Checked = false;
                abortRetryIgnoreCheckbox.Checked = false;
                retryCancelCheckbox.Checked = false;
                noneCheckbox.Checked = false;
            }
        }

        private void abortRetryIgnoreCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (abortRetryIgnoreCheckbox.Checked == true)
            {
                OKCheckbox.Checked = false;
                yesNoCancelCheckbox.Checked = false;
                OKCancelCheckbox.Checked = false;
                yesNoCheckbox.Checked = false;
                retryCancelCheckbox.Checked = false;
                noneCheckbox.Checked = false;
            }
        }

        private void retryCancelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (retryCancelCheckbox.Checked == true)
            {
                OKCheckbox.Checked = false;
                yesNoCancelCheckbox.Checked = false;
                OKCancelCheckbox.Checked = false;
                abortRetryIgnoreCheckbox.Checked = false;
                yesNoCheckbox.Checked = false;
                noneCheckbox.Checked = false;
            }
        }

        private void noneCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (noneCheckbox.Checked == true)
            {
                OKCheckbox.Checked = false;
                yesNoCancelCheckbox.Checked = false;
                OKCancelCheckbox.Checked = false;
                abortRetryIgnoreCheckbox.Checked = false;
                yesNoCheckbox.Checked = false;
                retryCancelCheckbox.Checked = false;
            }
        }

        private void errorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (errorCheckbox.Checked == true)
            {
                informationCheckbox.Checked = false;
                warningCheckbox.Checked = false;
                questionCheckbox.Checked = false;
                noIconCheckbox.Checked = false;
            }
        }

        private void informationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (informationCheckbox.Checked == true)
            {
                errorCheckbox.Checked = false;
                warningCheckbox.Checked = false;
                questionCheckbox.Checked = false;
                noIconCheckbox.Checked = false;
            }
        }

        private void warningCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (warningCheckbox.Checked == true)
            {
                informationCheckbox.Checked = false;
                errorCheckbox.Checked = false;
                questionCheckbox.Checked = false;
                noIconCheckbox.Checked = false;
            }
        }

        private void questionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (questionCheckbox.Checked == true)
            {
                informationCheckbox.Checked = false;
                warningCheckbox.Checked = false;
                errorCheckbox.Checked = false;
                noIconCheckbox.Checked = false;
            }
        }

        private void noIconCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (noIconCheckbox.Checked == true)
            {
                informationCheckbox.Checked = false;
                warningCheckbox.Checked = false;
                questionCheckbox.Checked = false;
                errorCheckbox.Checked = false;
            }
        }

        private void expmdeShowFooterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (expmdeShowFooterCheckbox.Checked == true)
            {
                expmdeShowContentCheckbox.Checked = false;
                expmdeHideCheckbox.Checked = false;
            }
        }

        private void expmdeShowContentCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (expmdeShowContentCheckbox.Checked == true)
            {
                expmdeShowFooterCheckbox.Checked = false;
                expmdeHideCheckbox.Checked = false;
            }
        }

        private void expmdeHideCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (expmdeHideCheckbox.Checked == true)
            {
                expmdeShowContentCheckbox.Checked = false;
                expmdeShowFooterCheckbox.Checked = false;
            }
        }

        private void footerIconError_CheckedChanged(object sender, EventArgs e)
        {
            if(footerIconError.Checked == true)
            {
                footerIconInfo.Checked = false;
                footerIconWarning.Checked = false;
                footerIconQuestion.Checked = false;
                footerIconNone.Checked = false;
            }
        }

        private void footerIconInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (footerIconInfo.Checked == true)
            {
                footerIconError.Checked = false;
                footerIconWarning.Checked = false;
                footerIconQuestion.Checked = false;
                footerIconNone.Checked = false;
            }
        }

        private void footerIconWarning_CheckedChanged(object sender, EventArgs e)
        {
            if (footerIconWarning.Checked == true)
            {
                footerIconInfo.Checked = false;
                footerIconError.Checked = false;
                footerIconQuestion.Checked = false;
                footerIconNone.Checked = false;
            }
        }

        private void footerIconQuestion_CheckedChanged(object sender, EventArgs e)
        {
            if (footerIconQuestion.Checked == true)
            {
                footerIconInfo.Checked = false;
                footerIconWarning.Checked = false;
                footerIconError.Checked = false;
                footerIconNone.Checked = false;
            }
        }

        private void footerIconNone_CheckedChanged(object sender, EventArgs e)
        {
            if (footerIconNone.Checked == true)
            {
                footerIconInfo.Checked = false;
                footerIconWarning.Checked = false;
                footerIconQuestion.Checked = false;
                footerIconError.Checked = false;
            }
        }

        private void aboutDialogCreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutDialogCreatorToolStripMenuItem.Checked = false;

            About aboutDialog = new About();
            aboutDialog.Show();
        }

        private void whatsThishowToUseThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whatsThishowToUseThisToolStripMenuItem.Checked = false;

            MessageBox.Show("To use 'Link', type in any Website you want (be sure to put in https:// at the beginning!). For 'Command' you need to type in a Command Prompt Command (eg: echo Hello World! & pause). You can only choose one of these.");
        }

        private void button1OKCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(button1OKCheckbox.Checked == true)
            {
                button1YesCheckbox.Checked = false;
                button1NoCheckbox.Checked = false;
                button1CancelCheckbox.Checked = false;
                button1CloseCheckbox.Checked = false;
                button1RetryCheckbox.Checked = false;
                button1NoneCheckbox.Checked = false;
            }
        }

        private void button1YesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button1YesCheckbox.Checked == true)
            {
                button1OKCheckbox.Checked = false;
                button1NoCheckbox.Checked = false;
                button1CancelCheckbox.Checked = false;
                button1CloseCheckbox.Checked = false;
                button1RetryCheckbox.Checked = false;
                button1NoneCheckbox.Checked = false;
            }
        }

        private void button1NoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button1NoCheckbox.Checked == true)
            {
                button1YesCheckbox.Checked = false;
                button1OKCheckbox.Checked = false;
                button1CancelCheckbox.Checked = false;
                button1CloseCheckbox.Checked = false;
                button1RetryCheckbox.Checked = false;
                button1NoneCheckbox.Checked = false;
            }
        }

        private void button1CancelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button1CancelCheckbox.Checked == true)
            {
                button1YesCheckbox.Checked = false;
                button1NoCheckbox.Checked = false;
                button1OKCheckbox.Checked = false;
                button1CloseCheckbox.Checked = false;
                button1RetryCheckbox.Checked = false;
                button1NoneCheckbox.Checked = false;
            }
        }

        private void button1CloseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button1CloseCheckbox.Checked == true)
            {
                button1YesCheckbox.Checked = false;
                button1NoCheckbox.Checked = false;
                button1CancelCheckbox.Checked = false;
                button1OKCheckbox.Checked = false;
                button1RetryCheckbox.Checked = false;
                button1NoneCheckbox.Checked = false;
            }
        }

        private void button1RetryCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button1RetryCheckbox.Checked == true)
            {
                button1YesCheckbox.Checked = false;
                button1NoCheckbox.Checked = false;
                button1CancelCheckbox.Checked = false;
                button1CloseCheckbox.Checked = false;
                button1OKCheckbox.Checked = false;
                button1NoneCheckbox.Checked = false;
            }
        }

        private void button1NoneCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button1NoneCheckbox.Checked == true)
            {
                button1YesCheckbox.Checked = false;
                button1NoCheckbox.Checked = false;
                button1CancelCheckbox.Checked = false;
                button1CloseCheckbox.Checked = false;
                button1RetryCheckbox.Checked = false;
                button1OKCheckbox.Checked = false;
            }
        }

        private void button2OKCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button2OKCheckbox.Checked == true)
            {
                button2YesCheckbox.Checked = false;
                button2NoCheckbox.Checked = false;
                button2CancelCheckbox.Checked = false;
                button2CloseCheckbox.Checked = false;
                button2RetryCheckbox.Checked = false;
                button2NoneCheckbox.Checked = false;
            }
        }

        private void button2YesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button2YesCheckbox.Checked == true)
            {
                button2OKCheckbox.Checked = false;
                button2NoCheckbox.Checked = false;
                button2CancelCheckbox.Checked = false;
                button2CloseCheckbox.Checked = false;
                button2RetryCheckbox.Checked = false;
                button2NoneCheckbox.Checked = false;
            }
        }

        private void button2NoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button2NoCheckbox.Checked == true)
            {
                button2YesCheckbox.Checked = false;
                button2OKCheckbox.Checked = false;
                button2CancelCheckbox.Checked = false;
                button2CloseCheckbox.Checked = false;
                button2RetryCheckbox.Checked = false;
                button2NoneCheckbox.Checked = false;
            }
        }

        private void button2CancelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button2CancelCheckbox.Checked == true)
            {
                button2YesCheckbox.Checked = false;
                button2NoCheckbox.Checked = false;
                button2OKCheckbox.Checked = false;
                button2CloseCheckbox.Checked = false;
                button2RetryCheckbox.Checked = false;
                button2NoneCheckbox.Checked = false;
            }
        }

        private void button2CloseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button2CloseCheckbox.Checked == true)
            {
                button2YesCheckbox.Checked = false;
                button2NoCheckbox.Checked = false;
                button2CancelCheckbox.Checked = false;
                button2OKCheckbox.Checked = false;
                button2RetryCheckbox.Checked = false;
                button2NoneCheckbox.Checked = false;
            }
        }

        private void button2RetryCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button2RetryCheckbox.Checked == true)
            {
                button2YesCheckbox.Checked = false;
                button2NoCheckbox.Checked = false;
                button2CancelCheckbox.Checked = false;
                button2CloseCheckbox.Checked = false;
                button2OKCheckbox.Checked = false;
                button2NoneCheckbox.Checked = false;
            }
        }

        private void button2NoneCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button2NoneCheckbox.Checked == true)
            {
                button2YesCheckbox.Checked = false;
                button2NoCheckbox.Checked = false;
                button2CancelCheckbox.Checked = false;
                button2CloseCheckbox.Checked = false;
                button2RetryCheckbox.Checked = false;
                button2OKCheckbox.Checked = false;
            }
        }

        private void button3OKCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button3OKCheckbox.Checked == true)
            {
                button3YesCheckbox.Checked = false;
                button3NoCheckbox.Checked = false;
                button3CancelCheckbox.Checked = false;
                button3CloseCheckbox.Checked = false;
                button3RetryCheckbox.Checked = false;
                button3NoneCheckbox.Checked = false;
            }
        }

        private void button3YesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button3YesCheckbox.Checked == true)
            {
                button3OKCheckbox.Checked = false;
                button3NoCheckbox.Checked = false;
                button3CancelCheckbox.Checked = false;
                button3CloseCheckbox.Checked = false;
                button3RetryCheckbox.Checked = false;
                button3NoneCheckbox.Checked = false;
            }
        }

        private void button3NoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button3NoCheckbox.Checked == true)
            {
                button3YesCheckbox.Checked = false;
                button3OKCheckbox.Checked = false;
                button3CancelCheckbox.Checked = false;
                button3CloseCheckbox.Checked = false;
                button3RetryCheckbox.Checked = false;
                button3NoneCheckbox.Checked = false;
            }
        }

        private void button3CancelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button3CancelCheckbox.Checked == true)
            {
                button3YesCheckbox.Checked = false;
                button3NoCheckbox.Checked = false;
                button3OKCheckbox.Checked = false;
                button3CloseCheckbox.Checked = false;
                button3RetryCheckbox.Checked = false;
                button3NoneCheckbox.Checked = false;
            }
        }

        private void button3CloseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button3CloseCheckbox.Checked == true)
            {
                button3YesCheckbox.Checked = false;
                button3NoCheckbox.Checked = false;
                button3CancelCheckbox.Checked = false;
                button3OKCheckbox.Checked = false;
                button3RetryCheckbox.Checked = false;
                button3NoneCheckbox.Checked = false;
            }
        }

        private void button3RetryCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button3RetryCheckbox.Checked == true)
            {
                button3YesCheckbox.Checked = false;
                button3NoCheckbox.Checked = false;
                button3CancelCheckbox.Checked = false;
                button3CloseCheckbox.Checked = false;
                button3OKCheckbox.Checked = false;
                button3NoneCheckbox.Checked = false;
            }
        }

        private void button3NoneCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button3NoneCheckbox.Checked == true)
            {
                button3YesCheckbox.Checked = false;
                button3NoCheckbox.Checked = false;
                button3CancelCheckbox.Checked = false;
                button3CloseCheckbox.Checked = false;
                button3RetryCheckbox.Checked = false;
                button3OKCheckbox.Checked = false;
            }
        }

        private void button4OKCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button4OKCheckbox.Checked == true)
            {
                button4YesCheckbox.Checked = false;
                button4NoCheckbox.Checked = false;
                button4CancelCheckbox.Checked = false;
                button4CloseCheckbox.Checked = false;
                button4RetryCheckbox.Checked = false;
                button4NoneCheckbox.Checked = false;
            }
        }

        private void button4YesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button4YesCheckbox.Checked == true)
            {
                button4OKCheckbox.Checked = false;
                button4NoCheckbox.Checked = false;
                button4CancelCheckbox.Checked = false;
                button4CloseCheckbox.Checked = false;
                button4RetryCheckbox.Checked = false;
                button4NoneCheckbox.Checked = false;
            }
        }

        private void button4NoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button4NoCheckbox.Checked == true)
            {
                button4YesCheckbox.Checked = false;
                button4OKCheckbox.Checked = false;
                button4CancelCheckbox.Checked = false;
                button4CloseCheckbox.Checked = false;
                button4RetryCheckbox.Checked = false;
                button4NoneCheckbox.Checked = false;
            }
        }

        private void button4CancelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button4CancelCheckbox.Checked == true)
            {
                button4YesCheckbox.Checked = false;
                button4NoCheckbox.Checked = false;
                button4OKCheckbox.Checked = false;
                button4CloseCheckbox.Checked = false;
                button4RetryCheckbox.Checked = false;
                button4NoneCheckbox.Checked = false;
            }
        }

        private void button4CloseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button4CloseCheckbox.Checked == true)
            {
                button4YesCheckbox.Checked = false;
                button4NoCheckbox.Checked = false;
                button4CancelCheckbox.Checked = false;
                button4OKCheckbox.Checked = false;
                button4RetryCheckbox.Checked = false;
                button4NoneCheckbox.Checked = false;
            }
        }

        private void button4RetryCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button4RetryCheckbox.Checked == true)
            {
                button4YesCheckbox.Checked = false;
                button4NoCheckbox.Checked = false;
                button4CancelCheckbox.Checked = false;
                button4CloseCheckbox.Checked = false;
                button4OKCheckbox.Checked = false;
                button4NoneCheckbox.Checked = false;
            }
        }

        private void button4NoneCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (button4NoneCheckbox.Checked == true)
            {
                button4YesCheckbox.Checked = false;
                button4NoCheckbox.Checked = false;
                button4CancelCheckbox.Checked = false;
                button4CloseCheckbox.Checked = false;
                button4RetryCheckbox.Checked = false;
                button4OKCheckbox.Checked = false;
            }
        }
    }
}
