using System;
using System.IO;
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

            if(ShieldGray.Checked)
            {
                Standardicon = TaskDialogStandardIcon.ShieldGrayHeader;
            } else if (ShieldRed.Checked)
            {
                Standardicon = TaskDialogStandardIcon.SecurityErrorHeader;
            } else if(blueShield.Checked)
            {
                Standardicon = TaskDialogStandardIcon.ShieldBlueHeader;
            } else if(yellowShield.Checked)
            {
                Standardicon = TaskDialogStandardIcon.SecurityWarningHeader;
            } else if(greenShield.Checked)
            {
                Standardicon = TaskDialogStandardIcon.SecuritySuccessHeader;
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

            if(linkText1TextBox.Text.Length == 0)
            {
                linkText1TextBox.Text = " ";
            }
            if(linkText2TextBox.Text.Length == 0)
            {
                linkText2TextBox.Text = " ";
            }
            if(customButtonTextTextBox.Text.Length == 0)
            {
                customButtonTextTextBox.Text = " ";
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
                ShieldRed.Checked = false;
                blueShield.Checked = false;
                yellowShield.Checked = false;
                greenShield.Checked = false;
                ShieldGray.Checked = false;
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
                ShieldRed.Checked = false;
                blueShield.Checked = false;
                yellowShield.Checked = false;
                greenShield.Checked = false;
                ShieldGray.Checked = false;
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
                ShieldRed.Checked = false;
                blueShield.Checked = false;
                yellowShield.Checked = false;
                greenShield.Checked = false;
                ShieldGray.Checked = false;
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
                ShieldRed.Checked = false;
                blueShield.Checked = false;
                yellowShield.Checked = false;
                greenShield.Checked = false;
                ShieldGray.Checked = false;
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
                ShieldRed.Checked = false;
                blueShield.Checked = false;
                yellowShield.Checked = false;
                greenShield.Checked = false;
                ShieldGray.Checked = false;
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

            MessageBox.Show("To use 'Link', type in any Website you want (be sure to put in https:// at the beginning!). For 'Command' you need to type in a Command Prompt Command (eg: echo Hello World! & pause). You can only choose one of these (have one empty).");
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

        private void ShieldGray_CheckedChanged(object sender, EventArgs e)
        {
            if(ShieldGray.Checked == true)
            {
                errorCheckbox.Checked = false;
                informationCheckbox.Checked = false;
                warningCheckbox.Checked = false;
                questionCheckbox.Checked = false;
                noIconCheckbox.Checked = false;
                ShieldRed.Checked = false;
                blueShield.Checked = false;
                yellowShield.Checked = false;
                greenShield.Checked = false;
            }
        }

        private void ShieldRed_CheckedChanged(object sender, EventArgs e)
        {
            if (ShieldRed.Checked == true)
            {
                errorCheckbox.Checked = false;
                informationCheckbox.Checked = false;
                warningCheckbox.Checked = false;
                questionCheckbox.Checked = false;
                noIconCheckbox.Checked = false;
                ShieldGray.Checked = false;
                blueShield.Checked = false;
                yellowShield.Checked = false;
                greenShield.Checked = false;
            }
        }

        private void blueShield_CheckedChanged(object sender, EventArgs e)
        {
            if (blueShield.Checked == true)
            {
                errorCheckbox.Checked = false;
                informationCheckbox.Checked = false;
                warningCheckbox.Checked = false;
                questionCheckbox.Checked = false;
                noIconCheckbox.Checked = false;
                ShieldGray.Checked = false;
                ShieldRed.Checked = false;
                yellowShield.Checked = false;
                greenShield.Checked = false;
            }
        }

        private void yellowShield_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowShield.Checked == true)
            {
                errorCheckbox.Checked = false;
                informationCheckbox.Checked = false;
                warningCheckbox.Checked = false;
                questionCheckbox.Checked = false;
                noIconCheckbox.Checked = false;
                ShieldGray.Checked = false;
                ShieldRed.Checked = false;
                blueShield.Checked = false;
                greenShield.Checked = false;
            }
        }

        private void greenShield_CheckedChanged(object sender, EventArgs e)
        {
            if (greenShield.Checked == true)
            {
                errorCheckbox.Checked = false;
                informationCheckbox.Checked = false;
                warningCheckbox.Checked = false;
                questionCheckbox.Checked = false;
                noIconCheckbox.Checked = false;
                ShieldGray.Checked = false;
                ShieldRed.Checked = false;
                blueShield.Checked = false;
                yellowShield.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool selectedButtonBasicOK = false;
            bool selectedButtonBasicYesNo = false;
            bool selectedButtonBasicYesNoCancel = false;
            bool selectedButtonBasicOKCancel = false;
            bool selectedButtonBasicAbortRetryIgnore = false;
            bool selectedButtonBasicRetryCancel = false;
            bool selectedButtonBasicNone = false;
            string messageText = String.Empty;
            string titleText = String.Empty;
            bool selectedIconError = false;
            bool selectedIconInformation = false;
            bool selectedIconWarning = false;
            bool selectedIconQuestion = false;
            bool selectedIconNone = false;

            if (DialogTypeDropdown.SelectedItem.ToString() == "Basic Dialog Box (Classic Error Message)")
            {
                if (OKCheckbox.Checked)
                {
                    selectedButtonBasicOK = true;
                }
                else if (yesNoCheckbox.Checked)
                {
                    selectedButtonBasicYesNo = true;
                }
                else if (yesNoCancelCheckbox.Checked)
                {
                    selectedButtonBasicYesNoCancel = true;
                }
                else if (OKCancelCheckbox.Checked)
                {
                    selectedButtonBasicOKCancel = true;
                }
                else if (abortRetryIgnoreCheckbox.Checked)
                {
                    selectedButtonBasicAbortRetryIgnore = true;
                }
                else if (retryCancelCheckbox.Checked)
                {
                    selectedButtonBasicRetryCancel = true;
                }
                else if (noneCheckbox.Checked)
                {
                    selectedButtonBasicNone = true;
                } else
                {
                    selectedButtonBasicNone = true;
                }
                if (messageTextTextBox.Text.Length > 0)
                {
                    messageText = messageTextTextBox.Text;
                }
                else
                {
                    messageText = " ";
                }
                if (titlebarTextTextBox.Text.Length > 0)
                {
                    titleText = titlebarTextTextBox.Text;
                } else
                {
                    titleText = " ";
                }
                if(errorCheckbox.Checked)
                {
                    selectedIconError = true;
                } else if(informationCheckbox.Checked)
                {
                    selectedIconInformation = true;
                } else if(warningCheckbox.Checked)
                {
                    selectedIconWarning = true;
                } else if(questionCheckbox.Checked)
                {
                    selectedIconQuestion = true;
                } else if(noIconCheckbox.Checked)
                {
                    selectedIconNone = true;
                } else
                {
                    selectedIconNone = true;
                }

                if (!File.Exists("./Exported.txt"))
                {

                    File.Create("./Exported.txt").Close();
                    using (StreamWriter sw = File.AppendText("./Exported.txt"))
                    {
                        sw.WriteLine("basic");
                        sw.WriteLine(selectedButtonBasicOK);
                        sw.WriteLine(selectedButtonBasicYesNo);
                        sw.WriteLine(selectedButtonBasicYesNoCancel);
                        sw.WriteLine(selectedButtonBasicOKCancel);
                        sw.WriteLine(selectedButtonBasicAbortRetryIgnore);
                        sw.WriteLine(selectedButtonBasicRetryCancel);
                        sw.WriteLine(selectedButtonBasicNone);
                        sw.WriteLine(messageText);
                        sw.WriteLine(titleText);
                        sw.WriteLine(selectedIconError);
                        sw.WriteLine(selectedIconInformation);
                        sw.WriteLine(selectedIconWarning);
                        sw.WriteLine(selectedIconQuestion);
                        sw.WriteLine(selectedIconNone);
                    }
                }
                else
                {
                    File.WriteAllText("./Exported.txt", String.Empty);
                    using (StreamWriter sw = File.AppendText("./Exported.txt"))
                    {
                        sw.WriteLine("basic");
                        sw.WriteLine(selectedButtonBasicOK);
                        sw.WriteLine(selectedButtonBasicYesNo);
                        sw.WriteLine(selectedButtonBasicYesNoCancel);
                        sw.WriteLine(selectedButtonBasicOKCancel);
                        sw.WriteLine(selectedButtonBasicAbortRetryIgnore);
                        sw.WriteLine(selectedButtonBasicRetryCancel);
                        sw.WriteLine(selectedButtonBasicNone);
                        sw.WriteLine(messageText);
                        sw.WriteLine(titleText);
                        sw.WriteLine(selectedIconError);
                        sw.WriteLine(selectedIconInformation);
                        sw.WriteLine(selectedIconWarning);
                        sw.WriteLine(selectedIconQuestion);
                        sw.WriteLine(selectedIconNone);
                    }
                }

            }

            int button1 = 0;
            int button2 = 0;
            int button3 = 0;
            int button4 = 0;
            bool cancelable = false;
            bool elevated = false;
            string instructionText = String.Empty;
            string captionText = String.Empty;
            string expandedText = String.Empty;
            string collapsedText = String.Empty;
            string extendedText = String.Empty;
            string footerCheckboxText = String.Empty;
            string footerText = String.Empty;
            int footerIcon = 0;
            int footerSetting = 0;

            string linkText1 = String.Empty;
            string linkText2 = String.Empty;

            string customButtonText = String.Empty;

            bool selectedIconGrayShield = false;
            bool selectedIconRedShield = false;
            bool selectedIconBlueShield = false;
            bool selectedIconYellowShield = false;
            bool selectedIconGreenShield = false;

            if(DialogTypeDropdown.SelectedItem.ToString() == "Task Dialog Box (More Advanced, and more customizable.)")
            {

                if (messageTextTextBox.Text.Length > 0)
                {
                    messageText = messageTextTextBox.Text;
                }
                else
                {
                    messageText = " ";
                }
                if (titlebarTextTextBox.Text.Length > 0)
                {
                    titleText = titlebarTextTextBox.Text;
                }
                else
                {
                    titleText = " ";
                }
                if (errorCheckbox.Checked)
                {
                    selectedIconError = true;
                }
                else if (informationCheckbox.Checked)
                {
                    selectedIconInformation = true;
                }
                else if (warningCheckbox.Checked)
                {
                    selectedIconWarning = true;
                }
                else if (questionCheckbox.Checked)
                {
                    selectedIconQuestion = true;
                }
                else if (noIconCheckbox.Checked)
                {
                    selectedIconNone = true;
                } else if(ShieldGray.Checked)
                {
                    selectedIconGrayShield = true;
                } else if(ShieldRed.Checked)
                {
                    selectedIconRedShield = true;
                } else if(blueShield.Checked)
                {
                    selectedIconBlueShield = true;
                } else if(yellowShield.Checked)
                {
                    selectedIconYellowShield = true;
                } else if(greenShield.Checked)
                {
                    selectedIconGreenShield = true;
                }
                else
                {
                    selectedIconNone = true;
                }
                if(button1OKCheckbox.Checked)
                {
                    button1 = 0;
                } else if(button1YesCheckbox.Checked)
                {
                    button1 = 1;
                } else if(button1NoCheckbox.Checked)
                {
                    button1 = 2;
                } else if(button1CancelCheckbox.Checked)
                {
                    button1 = 3;
                } else if(button1CloseCheckbox.Checked)
                {
                    button1 = 4;
                } else if(button1RetryCheckbox.Checked)
                {
                    button1 = 5;
                } else if(button1NoneCheckbox.Checked)
                {
                    button1 = 6;
                } else
                {
                    button1 = 6;
                }
                if (button2OKCheckbox.Checked)
                {
                    button2 = 0;
                }
                else if (button2YesCheckbox.Checked)
                {
                    button2 = 1;
                }
                else if (button2NoCheckbox.Checked)
                {
                    button2 = 2;
                }
                else if (button2CancelCheckbox.Checked)
                {
                    button2 = 3;
                }
                else if (button2CloseCheckbox.Checked)
                {
                    button2 = 4;
                }
                else if (button2RetryCheckbox.Checked)
                {
                    button2 = 5;
                }
                else if (button2NoneCheckbox.Checked)
                {
                    button2 = 6;
                }
                else
                {
                    button2 = 6;
                }
                if (button3OKCheckbox.Checked)
                {
                    button3 = 0;
                }
                else if (button3YesCheckbox.Checked)
                {
                    button3 = 1;
                }
                else if (button3NoCheckbox.Checked)
                {
                    button3 = 2;
                }
                else if (button3CancelCheckbox.Checked)
                {
                    button3 = 3;
                }
                else if (button3CloseCheckbox.Checked)
                {
                    button3 = 4;
                }
                else if (button3RetryCheckbox.Checked)
                {
                    button3 = 5;
                }
                else if (button3NoneCheckbox.Checked)
                {
                    button3 = 6;
                }
                else
                {
                    button3 = 6;
                }
                if (button4OKCheckbox.Checked)
                {
                    button4 = 0;
                }
                else if (button4YesCheckbox.Checked)
                {
                    button4 = 1;
                }
                else if (button4NoCheckbox.Checked)
                {
                    button4 = 2;
                }
                else if (button4CancelCheckbox.Checked)
                {
                    button4 = 3;
                }
                else if (button4CloseCheckbox.Checked)
                {
                    button4 = 4;
                }
                else if (button4RetryCheckbox.Checked)
                {
                    button4 = 5;
                }
                else if (button4NoneCheckbox.Checked)
                {
                    button4 = 6;
                }
                else
                {
                    button4 = 6;
                }
                if(cancelableCheckbox.Checked)
                {
                    cancelable = true;
                } else
                {
                    cancelable = false;
                }
                if(elevatedIconCheckbox.Checked)
                {
                    elevated = true;
                } else
                {
                    elevated = false;
                }
                if (instTextTextBox.Text.Length > 0)
                {
                    instructionText = instTextTextBox.Text;
                }
                else
                {
                    instructionText = "";
                }
                if (captionTextTextBox.Text.Length > 0)
                {
                    captionText = captionTextTextBox.Text;
                }
                else
                {
                    captionText = "";
                }
                if (expandTextTextBox.Text.Length > 0)
                {
                    expandedText = expandTextTextBox.Text;
                }
                else
                {
                    expandedText = "";
                }
                if (collapsedSeeDetailsTextBox.Text.Length > 0)
                {
                    collapsedText = collapsedSeeDetailsTextBox.Text;
                }
                else
                {
                    collapsedText = "";
                }
                if (extendedSeeDetailsTextBox.Text.Length > 0)
                {
                    extendedText = extendedSeeDetailsTextBox.Text;
                }
                else
                {
                    extendedText = "";
                }
                if (footerCheckBoxTextBox.Text.Length > 0)
                {
                    footerCheckboxText = footerCheckBoxTextBox.Text;
                }
                else
                {
                    footerCheckboxText = "";
                }
                if (footerTextBox.Text.Length > 0)
                {
                    footerText = footerTextBox.Text;
                }
                else
                {
                    footerText = "";
                }
                if(footerIconError.Checked)
                {
                    footerIcon = 0;
                } else if(footerIconInfo.Checked)
                {
                    footerIcon = 1;
                } else if(footerIconWarning.Checked)
                {
                    footerIcon = 2;
                } else if(footerIconQuestion.Checked)
                {
                    footerIcon = 3;
                } else if(footerIconNone.Checked)
                {
                    footerIcon = 4;
                } else
                {
                    footerIcon = 4;
                }
                if(expmdeShowFooterCheckbox.Checked)
                {
                    footerSetting = 0;
                } else if(expmdeShowContentCheckbox.Checked)
                {
                    footerSetting = 1;
                } else if(expmdeHideCheckbox.Checked)
                {
                    footerSetting = 2;
                } else
                {
                    footerSetting = 0;
                }

                if (!File.Exists("./Exported.txt"))
                {

                    File.Create("./Exported.txt").Close();
                    using (StreamWriter sw = File.AppendText("./Exported.txt"))
                    {
                        sw.WriteLine("advanced");
                        sw.WriteLine(messageText);
                        sw.WriteLine(titleText);
                        sw.WriteLine(selectedIconError);
                        sw.WriteLine(selectedIconInformation);
                        sw.WriteLine(selectedIconWarning);
                        sw.WriteLine(selectedIconQuestion);
                        sw.WriteLine(selectedIconNone);
                        sw.WriteLine(button1);
                        sw.WriteLine(button2);
                        sw.WriteLine(button3);
                        sw.WriteLine(button4);
                        sw.WriteLine(cancelable);
                        sw.WriteLine(elevated);
                        sw.WriteLine(instructionText);
                        sw.WriteLine(captionText);
                        sw.WriteLine(expandedText);
                        sw.WriteLine(collapsedText);
                        sw.WriteLine(extendedText);
                        sw.WriteLine(footerCheckboxText);
                        sw.WriteLine(footerText);
                        sw.WriteLine(footerIcon);
                        sw.WriteLine(footerSetting);
                        sw.WriteLine(selectedIconGrayShield);
                        sw.WriteLine(selectedIconRedShield);
                        sw.WriteLine(selectedIconBlueShield);
                        sw.WriteLine(selectedIconYellowShield);
                        sw.WriteLine(selectedIconGreenShield);
                    }
                }
                else
                {
                    File.WriteAllText("./Exported.txt", String.Empty);
                    using (StreamWriter sw = File.AppendText("./Exported.txt"))
                    {
                        sw.WriteLine("advanced");
                        sw.WriteLine(messageText);
                        sw.WriteLine(titleText);
                        sw.WriteLine(selectedIconError);
                        sw.WriteLine(selectedIconInformation);
                        sw.WriteLine(selectedIconWarning);
                        sw.WriteLine(selectedIconQuestion);
                        sw.WriteLine(selectedIconNone);
                        sw.WriteLine(button1);
                        sw.WriteLine(button2);
                        sw.WriteLine(button3);
                        sw.WriteLine(button4);
                        sw.WriteLine(cancelable);
                        sw.WriteLine(elevated);
                        sw.WriteLine(instructionText);
                        sw.WriteLine(captionText);
                        sw.WriteLine(expandedText);
                        sw.WriteLine(collapsedText);
                        sw.WriteLine(extendedText);
                        sw.WriteLine(footerCheckboxText);
                        sw.WriteLine(footerText);
                        sw.WriteLine(footerIcon);
                        sw.WriteLine(footerSetting);
                        sw.WriteLine(selectedIconGrayShield);
                        sw.WriteLine(selectedIconRedShield);
                        sw.WriteLine(selectedIconBlueShield);
                        sw.WriteLine(selectedIconYellowShield);
                        sw.WriteLine(selectedIconGreenShield);
                    }
                }
            }

            if (DialogTypeDropdown.SelectedItem.ToString() == "Task Dialog Box (More Advanced, and more customizable. Links Version)")
            {

                if (messageTextTextBox.Text.Length > 0)
                {
                    messageText = messageTextTextBox.Text;
                }
                else
                {
                    messageText = " ";
                }
                if (titlebarTextTextBox.Text.Length > 0)
                {
                    titleText = titlebarTextTextBox.Text;
                }
                else
                {
                    titleText = " ";
                }
                if (errorCheckbox.Checked)
                {
                    selectedIconError = true;
                }
                else if (informationCheckbox.Checked)
                {
                    selectedIconInformation = true;
                }
                else if (warningCheckbox.Checked)
                {
                    selectedIconWarning = true;
                }
                else if (questionCheckbox.Checked)
                {
                    selectedIconQuestion = true;
                }
                else if (noIconCheckbox.Checked)
                {
                    selectedIconNone = true;
                }
                else if (ShieldGray.Checked)
                {
                    selectedIconGrayShield = true;
                }
                else if (ShieldRed.Checked)
                {
                    selectedIconRedShield = true;
                }
                else if (blueShield.Checked)
                {
                    selectedIconBlueShield = true;
                }
                else if (yellowShield.Checked)
                {
                    selectedIconYellowShield = true;
                }
                else if (greenShield.Checked)
                {
                    selectedIconGreenShield = true;
                }
                else
                {
                    selectedIconNone = true;
                }
                if (button1OKCheckbox.Checked)
                {
                    button1 = 0;
                }
                else if (button1YesCheckbox.Checked)
                {
                    button1 = 1;
                }
                else if (button1NoCheckbox.Checked)
                {
                    button1 = 2;
                }
                else if (button1CancelCheckbox.Checked)
                {
                    button1 = 3;
                }
                else if (button1CloseCheckbox.Checked)
                {
                    button1 = 4;
                }
                else if (button1RetryCheckbox.Checked)
                {
                    button1 = 5;
                }
                else if (button1NoneCheckbox.Checked)
                {
                    button1 = 6;
                }
                else
                {
                    button1 = 6;
                }
                if (button2OKCheckbox.Checked)
                {
                    button2 = 0;
                }
                else if (button2YesCheckbox.Checked)
                {
                    button2 = 1;
                }
                else if (button2NoCheckbox.Checked)
                {
                    button2 = 2;
                }
                else if (button2CancelCheckbox.Checked)
                {
                    button2 = 3;
                }
                else if (button2CloseCheckbox.Checked)
                {
                    button2 = 4;
                }
                else if (button2RetryCheckbox.Checked)
                {
                    button2 = 5;
                }
                else if (button2NoneCheckbox.Checked)
                {
                    button2 = 6;
                }
                else
                {
                    button2 = 6;
                }
                if (button3OKCheckbox.Checked)
                {
                    button3 = 0;
                }
                else if (button3YesCheckbox.Checked)
                {
                    button3 = 1;
                }
                else if (button3NoCheckbox.Checked)
                {
                    button3 = 2;
                }
                else if (button3CancelCheckbox.Checked)
                {
                    button3 = 3;
                }
                else if (button3CloseCheckbox.Checked)
                {
                    button3 = 4;
                }
                else if (button3RetryCheckbox.Checked)
                {
                    button3 = 5;
                }
                else if (button3NoneCheckbox.Checked)
                {
                    button3 = 6;
                }
                else
                {
                    button3 = 6;
                }
                if (button4OKCheckbox.Checked)
                {
                    button4 = 0;
                }
                else if (button4YesCheckbox.Checked)
                {
                    button4 = 1;
                }
                else if (button4NoCheckbox.Checked)
                {
                    button4 = 2;
                }
                else if (button4CancelCheckbox.Checked)
                {
                    button4 = 3;
                }
                else if (button4CloseCheckbox.Checked)
                {
                    button4 = 4;
                }
                else if (button4RetryCheckbox.Checked)
                {
                    button4 = 5;
                }
                else if (button4NoneCheckbox.Checked)
                {
                    button4 = 6;
                }
                else
                {
                    button4 = 6;
                }
                if (cancelableCheckbox.Checked)
                {
                    cancelable = true;
                }
                else
                {
                    cancelable = false;
                }
                if (elevatedIconCheckbox.Checked)
                {
                    elevated = true;
                }
                else
                {
                    elevated = false;
                }
                if (instTextTextBox.Text.Length > 0)
                {
                    instructionText = instTextTextBox.Text;
                }
                else
                {
                    instructionText = "";
                }
                if (captionTextTextBox.Text.Length > 0)
                {
                    captionText = captionTextTextBox.Text;
                }
                else
                {
                    captionText = "";
                }
                if (expandTextTextBox.Text.Length > 0)
                {
                    expandedText = expandTextTextBox.Text;
                }
                else
                {
                    expandedText = "";
                }
                if (collapsedSeeDetailsTextBox.Text.Length > 0)
                {
                    collapsedText = collapsedSeeDetailsTextBox.Text;
                }
                else
                {
                    collapsedText = "";
                }
                if (extendedSeeDetailsTextBox.Text.Length > 0)
                {
                    extendedText = extendedSeeDetailsTextBox.Text;
                }
                else
                {
                    extendedText = "";
                }
                if (footerCheckBoxTextBox.Text.Length > 0)
                {
                    footerCheckboxText = footerCheckBoxTextBox.Text;
                }
                else
                {
                    footerCheckboxText = "";
                }
                if (footerTextBox.Text.Length > 0)
                {
                    footerText = footerTextBox.Text;
                }
                else
                {
                    footerText = "";
                }
                if (footerIconError.Checked)
                {
                    footerIcon = 0;
                }
                else if (footerIconInfo.Checked)
                {
                    footerIcon = 1;
                }
                else if (footerIconWarning.Checked)
                {
                    footerIcon = 2;
                }
                else if (footerIconQuestion.Checked)
                {
                    footerIcon = 3;
                }
                else if (footerIconNone.Checked)
                {
                    footerIcon = 4;
                }
                else
                {
                    footerIcon = 4;
                }
                if (expmdeShowFooterCheckbox.Checked)
                {
                    footerSetting = 0;
                }
                else if (expmdeShowContentCheckbox.Checked)
                {
                    footerSetting = 1;
                }
                else if (expmdeHideCheckbox.Checked)
                {
                    footerSetting = 2;
                }
                else
                {
                    footerSetting = 0;
                }
                if (linkText1TextBox.Text.Length > 0)
                {
                    linkText1 = linkText1TextBox.Text;
                }
                else
                {
                    linkText1 = " ";
                }
                if (linkText2TextBox.Text.Length > 0)
                {
                    linkText2 = linkText2TextBox.Text;
                }
                else
                {
                    linkText2 = " ";
                }

                if (!File.Exists("./Exported.txt"))
                {

                    File.Create("./Exported.txt").Close();
                    using (StreamWriter sw = File.AppendText("./Exported.txt"))
                    {
                        sw.WriteLine("advancedlink");
                        sw.WriteLine(messageText);
                        sw.WriteLine(titleText);
                        sw.WriteLine(selectedIconError);
                        sw.WriteLine(selectedIconInformation);
                        sw.WriteLine(selectedIconWarning);
                        sw.WriteLine(selectedIconQuestion);
                        sw.WriteLine(selectedIconNone);
                        sw.WriteLine(button1);
                        sw.WriteLine(button2);
                        sw.WriteLine(button3);
                        sw.WriteLine(button4);
                        sw.WriteLine(cancelable);
                        sw.WriteLine(elevated);
                        sw.WriteLine(instructionText);
                        sw.WriteLine(captionText);
                        sw.WriteLine(expandedText);
                        sw.WriteLine(collapsedText);
                        sw.WriteLine(extendedText);
                        sw.WriteLine(footerCheckboxText);
                        sw.WriteLine(footerText);
                        sw.WriteLine(footerIcon);
                        sw.WriteLine(footerSetting);
                        sw.WriteLine(linkText1);
                        sw.WriteLine(linkText2);
                        sw.WriteLine(selectedIconGrayShield);
                        sw.WriteLine(selectedIconRedShield);
                        sw.WriteLine(selectedIconBlueShield);
                        sw.WriteLine(selectedIconYellowShield);
                        sw.WriteLine(selectedIconGreenShield);
                    }
                }
                else
                {
                    File.WriteAllText("./Exported.txt", String.Empty);
                    using (StreamWriter sw = File.AppendText("./Exported.txt"))
                    {
                        sw.WriteLine("advancedlink");
                        sw.WriteLine(messageText);
                        sw.WriteLine(titleText);
                        sw.WriteLine(selectedIconError);
                        sw.WriteLine(selectedIconInformation);
                        sw.WriteLine(selectedIconWarning);
                        sw.WriteLine(selectedIconQuestion);
                        sw.WriteLine(selectedIconNone);
                        sw.WriteLine(button1);
                        sw.WriteLine(button2);
                        sw.WriteLine(button3);
                        sw.WriteLine(button4);
                        sw.WriteLine(cancelable);
                        sw.WriteLine(elevated);
                        sw.WriteLine(instructionText);
                        sw.WriteLine(captionText);
                        sw.WriteLine(expandedText);
                        sw.WriteLine(collapsedText);
                        sw.WriteLine(extendedText);
                        sw.WriteLine(footerCheckboxText);
                        sw.WriteLine(footerText);
                        sw.WriteLine(footerIcon);
                        sw.WriteLine(footerSetting);
                        sw.WriteLine(linkText1);
                        sw.WriteLine(linkText2);
                        sw.WriteLine(selectedIconGrayShield);
                        sw.WriteLine(selectedIconRedShield);
                        sw.WriteLine(selectedIconBlueShield);
                        sw.WriteLine(selectedIconYellowShield);
                        sw.WriteLine(selectedIconGreenShield);
                    }
                }
            }

            if (DialogTypeDropdown.SelectedItem.ToString() == "Task Dialog Box (More Advanced, and more customizable. Custom Buttons Version)")
            {

                if (messageTextTextBox.Text.Length > 0)
                {
                    messageText = messageTextTextBox.Text;
                }
                else
                {
                    messageText = " ";
                }
                if (titlebarTextTextBox.Text.Length > 0)
                {
                    titleText = titlebarTextTextBox.Text;
                }
                else
                {
                    titleText = " ";
                }
                if (errorCheckbox.Checked)
                {
                    selectedIconError = true;
                }
                else if (informationCheckbox.Checked)
                {
                    selectedIconInformation = true;
                }
                else if (warningCheckbox.Checked)
                {
                    selectedIconWarning = true;
                }
                else if (questionCheckbox.Checked)
                {
                    selectedIconQuestion = true;
                }
                else if (noIconCheckbox.Checked)
                {
                    selectedIconNone = true;
                }
                else if (ShieldGray.Checked)
                {
                    selectedIconGrayShield = true;
                }
                else if (ShieldRed.Checked)
                {
                    selectedIconRedShield = true;
                }
                else if (blueShield.Checked)
                {
                    selectedIconBlueShield = true;
                }
                else if (yellowShield.Checked)
                {
                    selectedIconYellowShield = true;
                }
                else if (greenShield.Checked)
                {
                    selectedIconGreenShield = true;
                }
                else
                {
                    selectedIconNone = true;
                }
                if (customButtonTextTextBox.Text.Length > 0)
                {
                    customButtonText = customButtonTextTextBox.Text;
                }
                else
                {
                    customButtonText = " ";
                }
                if (cancelableCheckbox.Checked)
                {
                    cancelable = true;
                }
                else
                {
                    cancelable = false;
                }
                if (elevatedIconCheckbox.Checked)
                {
                    elevated = true;
                }
                else
                {
                    elevated = false;
                }
                if (instTextTextBox.Text.Length > 0)
                {
                    instructionText = instTextTextBox.Text;
                }
                else
                {
                    instructionText = "";
                }
                if (captionTextTextBox.Text.Length > 0)
                {
                    captionText = captionTextTextBox.Text;
                }
                else
                {
                    captionText = "";
                }
                if (expandTextTextBox.Text.Length > 0)
                {
                    expandedText = expandTextTextBox.Text;
                }
                else
                {
                    expandedText = "";
                }
                if (collapsedSeeDetailsTextBox.Text.Length > 0)
                {
                    collapsedText = collapsedSeeDetailsTextBox.Text;
                }
                else
                {
                    collapsedText = "";
                }
                if (extendedSeeDetailsTextBox.Text.Length > 0)
                {
                    extendedText = extendedSeeDetailsTextBox.Text;
                }
                else
                {
                    extendedText = "";
                }
                if (footerCheckBoxTextBox.Text.Length > 0)
                {
                    footerCheckboxText = footerCheckBoxTextBox.Text;
                }
                else
                {
                    footerCheckboxText = "";
                }
                if (footerTextBox.Text.Length > 0)
                {
                    footerText = footerTextBox.Text;
                }
                else
                {
                    footerText = "";
                }
                if (footerIconError.Checked)
                {
                    footerIcon = 0;
                }
                else if (footerIconInfo.Checked)
                {
                    footerIcon = 1;
                }
                else if (footerIconWarning.Checked)
                {
                    footerIcon = 2;
                }
                else if (footerIconQuestion.Checked)
                {
                    footerIcon = 3;
                }
                else if (footerIconNone.Checked)
                {
                    footerIcon = 4;
                }
                else
                {
                    footerIcon = 4;
                }
                if (expmdeShowFooterCheckbox.Checked)
                {
                    footerSetting = 0;
                }
                else if (expmdeShowContentCheckbox.Checked)
                {
                    footerSetting = 1;
                }
                else if (expmdeHideCheckbox.Checked)
                {
                    footerSetting = 2;
                }
                else
                {
                    footerSetting = 0;
                }

                if (!File.Exists("./Exported.txt"))
                {

                    File.Create("./Exported.txt").Close();
                    using (StreamWriter sw = File.AppendText("./Exported.txt"))
                    {
                        sw.WriteLine("advancedbutton");
                        sw.WriteLine(messageText);
                        sw.WriteLine(titleText);
                        sw.WriteLine(selectedIconError);
                        sw.WriteLine(selectedIconInformation);
                        sw.WriteLine(selectedIconWarning);
                        sw.WriteLine(selectedIconQuestion);
                        sw.WriteLine(selectedIconNone);
                        sw.WriteLine(button1);
                        sw.WriteLine(button2);
                        sw.WriteLine(button3);
                        sw.WriteLine(button4);
                        sw.WriteLine(cancelable);
                        sw.WriteLine(elevated);
                        sw.WriteLine(instructionText);
                        sw.WriteLine(captionText);
                        sw.WriteLine(expandedText);
                        sw.WriteLine(collapsedText);
                        sw.WriteLine(extendedText);
                        sw.WriteLine(footerCheckboxText);
                        sw.WriteLine(footerText);
                        sw.WriteLine(footerIcon);
                        sw.WriteLine(footerSetting);
                        sw.WriteLine(customButtonText);
                        sw.WriteLine(selectedIconGrayShield);
                        sw.WriteLine(selectedIconRedShield);
                        sw.WriteLine(selectedIconBlueShield);
                        sw.WriteLine(selectedIconYellowShield);
                        sw.WriteLine(selectedIconGreenShield);
                    }
                }
                else
                {
                    File.WriteAllText("./Exported.txt", String.Empty);
                    using (StreamWriter sw = File.AppendText("./Exported.txt"))
                    {
                        sw.WriteLine("advancedbutton");
                        sw.WriteLine(messageText);
                        sw.WriteLine(titleText);
                        sw.WriteLine(selectedIconError);
                        sw.WriteLine(selectedIconInformation);
                        sw.WriteLine(selectedIconWarning);
                        sw.WriteLine(selectedIconQuestion);
                        sw.WriteLine(selectedIconNone);
                        sw.WriteLine(button1);
                        sw.WriteLine(button2);
                        sw.WriteLine(button3);
                        sw.WriteLine(button4);
                        sw.WriteLine(cancelable);
                        sw.WriteLine(elevated);
                        sw.WriteLine(instructionText);
                        sw.WriteLine(captionText);
                        sw.WriteLine(expandedText);
                        sw.WriteLine(collapsedText);
                        sw.WriteLine(extendedText);
                        sw.WriteLine(footerCheckboxText);
                        sw.WriteLine(footerText);
                        sw.WriteLine(footerIcon);
                        sw.WriteLine(footerSetting);
                        sw.WriteLine(customButtonText);
                        sw.WriteLine(selectedIconGrayShield);
                        sw.WriteLine(selectedIconRedShield);
                        sw.WriteLine(selectedIconBlueShield);
                        sw.WriteLine(selectedIconYellowShield);
                        sw.WriteLine(selectedIconGreenShield);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string messageType; // 0
            bool selectedButtonBasicOK = false; // 1
            bool selectedButtonBasicYesNo = false; // 2
            bool selectedButtonBasicYesNoCancel = false; // 3
            bool selectedButtonBasicOKCancel = false; // 4
            bool selectedButtonBasicAbortRetryIgnore = false; // 5
            bool selectedButtonBasicRetryCancel = false; // 6
            bool selectedButtonBasicNone = false; // 7
            string messageText = String.Empty; // 8 Task Dialog: 1
            string titleText = String.Empty; // 9 Task Dialog: 2
            bool selectedIconError = false; // 10 Task Dialog: 3
            bool selectedIconInformation = false; // 11 Task Dialog: 4
            bool selectedIconWarning = false; // 12 Task Dialog: 5
            bool selectedIconQuestion = false; // 13 Task Dialog: 6
            bool selectedIconNone = false; // 14 Task Dialog: 7
            // Why are these marked down with numbers? Because I thought there was a issue with lines in the Exported.txt file but there isnt..


            // Task Dialog stuff
            int button1;
            int button2;
            int button3;
            int button4;
            bool cancelable;
            bool elevated;
            string instructionText;
            string captionText;
            string expandedText;
            string collapsedText;
            string extendedText;
            string footerCheckboxText;
            string footerText;
            int footerIcon;
            int footerSetting;

            string linkText1;
            string linkText2;

            string customButtonText;

            bool selectedIconGrayShield;
            bool selectedIconRedShield;
            bool selectedIconBlueShield;
            bool selectedIconYellowShield;
            bool selectedIconGreenShield;

            if (!File.Exists("./Exported.txt"))
            {
                MessageBox.Show("Exported.txt does not exist! Put it in the same directory as the program!");
            } else
            {
                string[] exportedFile = File.ReadAllLines("./Exported.txt");

                if (exportedFile[0] == "basic")
                {
                    Console.WriteLine("Basic Message!");
                    // Write the values to their respective variables
                    selectedButtonBasicOK = bool.Parse(exportedFile[1]);
                    selectedButtonBasicYesNo = bool.Parse(exportedFile[2]);
                    selectedButtonBasicYesNoCancel = bool.Parse(exportedFile[3]);
                    selectedButtonBasicOKCancel = bool.Parse(exportedFile[4]);
                    selectedButtonBasicAbortRetryIgnore = bool.Parse(exportedFile[5]);
                    selectedButtonBasicRetryCancel = bool.Parse(exportedFile[6]);
                    selectedButtonBasicNone = bool.Parse(exportedFile[7]);
                    messageText = exportedFile[8];
                    titleText = exportedFile[9];
                    selectedIconError = bool.Parse(exportedFile[10]);
                    selectedIconInformation = bool.Parse(exportedFile[11]);
                    selectedIconWarning = bool.Parse(exportedFile[12]);
                    selectedIconQuestion = bool.Parse(exportedFile[13]);
                    selectedIconNone = bool.Parse(exportedFile[14]);

                    // Apply the values
                    OKCheckbox.Checked = selectedButtonBasicOK;
                    yesNoCheckbox.Checked = selectedButtonBasicYesNo;
                    yesNoCancelCheckbox.Checked = selectedButtonBasicYesNoCancel;
                    OKCancelCheckbox.Checked = selectedButtonBasicOKCancel;
                    abortRetryIgnoreCheckbox.Checked = selectedButtonBasicAbortRetryIgnore;
                    retryCancelCheckbox.Checked = selectedButtonBasicRetryCancel;
                    noneCheckbox.Checked = selectedButtonBasicNone;
                    messageTextTextBox.Text = messageText;
                    titlebarTextTextBox.Text = titleText;
                    errorCheckbox.Checked = selectedIconError;
                    informationCheckbox.Checked = selectedIconInformation;
                    warningCheckbox.Checked = selectedIconWarning;
                    questionCheckbox.Checked = selectedIconQuestion;
                    noneCheckbox.Checked = selectedIconNone;

                } else if(exportedFile[0] == "advanced")
                {
                    Console.WriteLine("Advanced Message!");
                    // Write the values to their respective variables
                    messageText = exportedFile[1];
                    titleText = exportedFile[2];
                    selectedIconError = bool.Parse(exportedFile[3]);
                    selectedIconInformation = bool.Parse(exportedFile[4]);
                    selectedIconWarning = bool.Parse(exportedFile[5]);
                    selectedIconQuestion = bool.Parse(exportedFile[6]);
                    selectedIconNone = bool.Parse(exportedFile[7]);
                    button1 = int.Parse(exportedFile[8]);
                    button2 = int.Parse(exportedFile[9]);
                    button3 = int.Parse(exportedFile[10]);
                    button4 = int.Parse(exportedFile[11]);
                    cancelable = bool.Parse(exportedFile[12]);
                    elevated = bool.Parse(exportedFile[13]);
                    instructionText = exportedFile[14];
                    captionText = exportedFile[15];
                    expandedText = exportedFile[16];
                    collapsedText = exportedFile[17];
                    extendedText = exportedFile[18];
                    footerCheckboxText = exportedFile[19];
                    footerText = exportedFile[20];
                    footerIcon = int.Parse(exportedFile[21]);
                    footerSetting = int.Parse(exportedFile[22]);
                    selectedIconGrayShield = bool.Parse(exportedFile[23]);
                    selectedIconRedShield = bool.Parse(exportedFile[24]);
                    selectedIconBlueShield = bool.Parse(exportedFile[25]);
                    selectedIconYellowShield = bool.Parse(exportedFile[26]);
                    selectedIconGreenShield = bool.Parse(exportedFile[27]);

                    // Apply the values
                    messageTextTextBox.Text = messageText;
                    titlebarTextTextBox.Text = titleText;
                    errorCheckbox.Checked = selectedIconError;
                    informationCheckbox.Checked = selectedIconInformation;
                    warningCheckbox.Checked = selectedIconWarning;
                    questionCheckbox.Checked = selectedIconQuestion;
                    ShieldGray.Checked = selectedIconGrayShield;
                    ShieldRed.Checked = selectedIconRedShield;
                    blueShield.Checked = selectedIconBlueShield;
                    yellowShield.Checked = selectedIconYellowShield;
                    greenShield.Checked = selectedIconGreenShield;
                    noneCheckbox.Checked = selectedIconNone;
                    if(button1 == 0)
                    {
                        button1OKCheckbox.Checked = true;
                    } else if(button1 == 1)
                    {
                        button1YesCheckbox.Checked = true;
                    } else if(button1 == 2)
                    {
                        button1NoCheckbox.Checked = true;
                    } else if(button1 == 3)
                    {
                        button1CancelCheckbox.Checked = true;
                    } else if(button1 == 4)
                    {
                        button1CloseCheckbox.Checked = true;
                    } else if(button1 == 5)
                    {
                        button1RetryCheckbox.Checked = true;
                    } else if(button1 == 6)
                    {
                        button1NoneCheckbox.Checked = true;
                    } else
                    {
                        button1NoneCheckbox.Checked = true;
                    }
                    if (button2 == 0)
                    {
                        button2OKCheckbox.Checked = true;
                    }
                    else if (button2 == 1)
                    {
                        button2YesCheckbox.Checked = true;
                    }
                    else if (button2 == 2)
                    {
                        button2NoCheckbox.Checked = true;
                    }
                    else if (button2 == 3)
                    {
                        button2CancelCheckbox.Checked = true;
                    }
                    else if (button2 == 4)
                    {
                        button2CloseCheckbox.Checked = true;
                    }
                    else if (button2 == 5)
                    {
                        button2RetryCheckbox.Checked = true;
                    }
                    else if (button2 == 6)
                    {
                        button2NoneCheckbox.Checked = true;
                    }
                    else
                    {
                        button2NoneCheckbox.Checked = true;
                    }
                    if (button3 == 0)
                    {
                        button3OKCheckbox.Checked = true;
                    }
                    else if (button3 == 1)
                    {
                        button3YesCheckbox.Checked = true;
                    }
                    else if (button3 == 2)
                    {
                        button3NoCheckbox.Checked = true;
                    }
                    else if (button3 == 3)
                    {
                        button3CancelCheckbox.Checked = true;
                    }
                    else if (button3 == 4)
                    {
                        button3CloseCheckbox.Checked = true;
                    }
                    else if (button3 == 5)
                    {
                        button3RetryCheckbox.Checked = true;
                    }
                    else if (button3 == 6)
                    {
                        button3NoneCheckbox.Checked = true;
                    }
                    else
                    {
                        button3NoneCheckbox.Checked = true;
                    }
                    if (button4 == 0)
                    {
                        button4OKCheckbox.Checked = true;
                    }
                    else if (button4 == 1)
                    {
                        button4YesCheckbox.Checked = true;
                    }
                    else if (button4 == 2)
                    {
                        button4NoCheckbox.Checked = true;
                    }
                    else if (button4 == 3)
                    {
                        button4CancelCheckbox.Checked = true;
                    }
                    else if (button4 == 4)
                    {
                        button4CloseCheckbox.Checked = true;
                    }
                    else if (button4 == 5)
                    {
                        button4RetryCheckbox.Checked = true;
                    }
                    else if (button4 == 6)
                    {
                        button4NoneCheckbox.Checked = true;
                    }
                    else
                    {
                        button4NoneCheckbox.Checked = true;
                    }
                    cancelableCheckbox.Checked = cancelable;
                    elevatedIconCheckbox.Checked = elevated;
                    instTextTextBox.Text = instructionText;
                    captionTextTextBox.Text = captionText;
                    expandTextTextBox.Text = expandedText;
                    collapsedSeeDetailsTextBox.Text = collapsedText;
                    extendedSeeDetailsTextBox.Text = extendedText;
                    footerCheckBoxTextBox.Text = footerCheckboxText;
                    footerTextBox.Text = footerText;
                    if(footerIcon == 0)
                    {
                        footerIconError.Checked = true;
                    } else if(footerIcon == 1)
                    {
                        footerIconInfo.Checked = true;
                    } else if(footerIcon == 2)
                    {
                        footerIconWarning.Checked = true;
                    } else if(footerIcon == 3)
                    {
                        footerIconQuestion.Checked = true;
                    } else if(footerIcon == 4)
                    {
                        footerIconNone.Checked = true;
                    } else
                    {
                        footerIconNone.Checked = true;
                    }
                }
                else if (exportedFile[0] == "advancedlink")
                {
                    Console.WriteLine("Advanced Links Message!");
                    // Write the values to their respective variables
                    messageText = exportedFile[1];
                    titleText = exportedFile[2];
                    selectedIconError = bool.Parse(exportedFile[3]);
                    selectedIconInformation = bool.Parse(exportedFile[4]);
                    selectedIconWarning = bool.Parse(exportedFile[5]);
                    selectedIconQuestion = bool.Parse(exportedFile[6]);
                    selectedIconNone = bool.Parse(exportedFile[7]);
                    button1 = int.Parse(exportedFile[8]);
                    button2 = int.Parse(exportedFile[9]);
                    button3 = int.Parse(exportedFile[10]);
                    button4 = int.Parse(exportedFile[11]);
                    cancelable = bool.Parse(exportedFile[12]);
                    elevated = bool.Parse(exportedFile[13]);
                    instructionText = exportedFile[14];
                    captionText = exportedFile[15];
                    expandedText = exportedFile[16];
                    collapsedText = exportedFile[17];
                    extendedText = exportedFile[18];
                    footerCheckboxText = exportedFile[19];
                    footerText = exportedFile[20];
                    footerIcon = int.Parse(exportedFile[21]);
                    footerSetting = int.Parse(exportedFile[22]);
                    linkText1 = exportedFile[23];
                    linkText2 = exportedFile[24];
                    selectedIconGrayShield = bool.Parse(exportedFile[25]);
                    selectedIconRedShield = bool.Parse(exportedFile[26]);
                    selectedIconBlueShield = bool.Parse(exportedFile[27]);
                    selectedIconYellowShield = bool.Parse(exportedFile[28]);
                    selectedIconGreenShield = bool.Parse(exportedFile[29]);


                    // Apply the values
                    messageTextTextBox.Text = messageText;
                    titlebarTextTextBox.Text = titleText;
                    errorCheckbox.Checked = selectedIconError;
                    informationCheckbox.Checked = selectedIconInformation;
                    warningCheckbox.Checked = selectedIconWarning;
                    questionCheckbox.Checked = selectedIconQuestion;
                    ShieldGray.Checked = selectedIconGrayShield;
                    ShieldRed.Checked = selectedIconRedShield;
                    blueShield.Checked = selectedIconBlueShield;
                    yellowShield.Checked = selectedIconYellowShield;
                    greenShield.Checked = selectedIconGreenShield;
                    noneCheckbox.Checked = selectedIconNone;
                    if (button1 == 0)
                    {
                        button1OKCheckbox.Checked = true;
                    }
                    else if (button1 == 1)
                    {
                        button1YesCheckbox.Checked = true;
                    }
                    else if (button1 == 2)
                    {
                        button1NoCheckbox.Checked = true;
                    }
                    else if (button1 == 3)
                    {
                        button1CancelCheckbox.Checked = true;
                    }
                    else if (button1 == 4)
                    {
                        button1CloseCheckbox.Checked = true;
                    }
                    else if (button1 == 5)
                    {
                        button1RetryCheckbox.Checked = true;
                    }
                    else if (button1 == 6)
                    {
                        button1NoneCheckbox.Checked = true;
                    }
                    else
                    {
                        button1NoneCheckbox.Checked = true;
                    }
                    if (button2 == 0)
                    {
                        button2OKCheckbox.Checked = true;
                    }
                    else if (button2 == 1)
                    {
                        button2YesCheckbox.Checked = true;
                    }
                    else if (button2 == 2)
                    {
                        button2NoCheckbox.Checked = true;
                    }
                    else if (button2 == 3)
                    {
                        button2CancelCheckbox.Checked = true;
                    }
                    else if (button2 == 4)
                    {
                        button2CloseCheckbox.Checked = true;
                    }
                    else if (button2 == 5)
                    {
                        button2RetryCheckbox.Checked = true;
                    }
                    else if (button2 == 6)
                    {
                        button2NoneCheckbox.Checked = true;
                    }
                    else
                    {
                        button2NoneCheckbox.Checked = true;
                    }
                    if (button3 == 0)
                    {
                        button3OKCheckbox.Checked = true;
                    }
                    else if (button3 == 1)
                    {
                        button3YesCheckbox.Checked = true;
                    }
                    else if (button3 == 2)
                    {
                        button3NoCheckbox.Checked = true;
                    }
                    else if (button3 == 3)
                    {
                        button3CancelCheckbox.Checked = true;
                    }
                    else if (button3 == 4)
                    {
                        button3CloseCheckbox.Checked = true;
                    }
                    else if (button3 == 5)
                    {
                        button3RetryCheckbox.Checked = true;
                    }
                    else if (button3 == 6)
                    {
                        button3NoneCheckbox.Checked = true;
                    }
                    else
                    {
                        button3NoneCheckbox.Checked = true;
                    }
                    if (button4 == 0)
                    {
                        button4OKCheckbox.Checked = true;
                    }
                    else if (button4 == 1)
                    {
                        button4YesCheckbox.Checked = true;
                    }
                    else if (button4 == 2)
                    {
                        button4NoCheckbox.Checked = true;
                    }
                    else if (button4 == 3)
                    {
                        button4CancelCheckbox.Checked = true;
                    }
                    else if (button4 == 4)
                    {
                        button4CloseCheckbox.Checked = true;
                    }
                    else if (button4 == 5)
                    {
                        button4RetryCheckbox.Checked = true;
                    }
                    else if (button4 == 6)
                    {
                        button4NoneCheckbox.Checked = true;
                    }
                    else
                    {
                        button4NoneCheckbox.Checked = true;
                    }
                    cancelableCheckbox.Checked = cancelable;
                    elevatedIconCheckbox.Checked = elevated;
                    instTextTextBox.Text = instructionText;
                    captionTextTextBox.Text = captionText;
                    expandTextTextBox.Text = expandedText;
                    collapsedSeeDetailsTextBox.Text = collapsedText;
                    extendedSeeDetailsTextBox.Text = extendedText;
                    footerCheckBoxTextBox.Text = footerCheckboxText;
                    footerTextBox.Text = footerText;
                    if (footerIcon == 0)
                    {
                        footerIconError.Checked = true;
                    }
                    else if (footerIcon == 1)
                    {
                        footerIconInfo.Checked = true;
                    }
                    else if (footerIcon == 2)
                    {
                        footerIconWarning.Checked = true;
                    }
                    else if (footerIcon == 3)
                    {
                        footerIconQuestion.Checked = true;
                    }
                    else if (footerIcon == 4)
                    {
                        footerIconNone.Checked = true;
                    }
                    else
                    {
                        footerIconNone.Checked = true;
                    }

                    linkText1TextBox.Text = linkText1;
                    linkText2TextBox.Text = linkText2;
                }
                else if (exportedFile[0] == "advancedbutton")
                {
                    Console.WriteLine("Advanced Custom Buttons Message!");
                    // Write the values to their respective variables
                    messageText = exportedFile[1];
                    titleText = exportedFile[2];
                    selectedIconError = bool.Parse(exportedFile[3]);
                    selectedIconInformation = bool.Parse(exportedFile[4]);
                    selectedIconWarning = bool.Parse(exportedFile[5]);
                    selectedIconQuestion = bool.Parse(exportedFile[6]);
                    selectedIconNone = bool.Parse(exportedFile[7]);
                    cancelable = bool.Parse(exportedFile[12]);
                    elevated = bool.Parse(exportedFile[13]);
                    instructionText = exportedFile[14];
                    captionText = exportedFile[15];
                    expandedText = exportedFile[16];
                    collapsedText = exportedFile[17];
                    extendedText = exportedFile[18];
                    footerCheckboxText = exportedFile[19];
                    footerText = exportedFile[20];
                    footerIcon = int.Parse(exportedFile[21]);
                    footerSetting = int.Parse(exportedFile[22]);
                    customButtonText = exportedFile[23];
                    selectedIconGrayShield = bool.Parse(exportedFile[24]);
                    selectedIconRedShield = bool.Parse(exportedFile[25]);
                    selectedIconBlueShield = bool.Parse(exportedFile[26]);
                    selectedIconYellowShield = bool.Parse(exportedFile[27]);
                    selectedIconGreenShield = bool.Parse(exportedFile[28]);

                    // Apply the values
                    messageTextTextBox.Text = messageText;
                    titlebarTextTextBox.Text = titleText;
                    errorCheckbox.Checked = selectedIconError;
                    informationCheckbox.Checked = selectedIconInformation;
                    warningCheckbox.Checked = selectedIconWarning;
                    questionCheckbox.Checked = selectedIconQuestion;
                    ShieldGray.Checked = selectedIconGrayShield;
                    ShieldRed.Checked = selectedIconRedShield;
                    blueShield.Checked = selectedIconBlueShield;
                    yellowShield.Checked = selectedIconYellowShield;
                    greenShield.Checked = selectedIconGreenShield;
                    noneCheckbox.Checked = selectedIconNone;
                    
                    cancelableCheckbox.Checked = cancelable;
                    elevatedIconCheckbox.Checked = elevated;
                    instTextTextBox.Text = instructionText;
                    captionTextTextBox.Text = captionText;
                    expandTextTextBox.Text = expandedText;
                    collapsedSeeDetailsTextBox.Text = collapsedText;
                    extendedSeeDetailsTextBox.Text = extendedText;
                    footerCheckBoxTextBox.Text = footerCheckboxText;
                    footerTextBox.Text = footerText;
                    if (footerIcon == 0)
                    {
                        footerIconError.Checked = true;
                    }
                    else if (footerIcon == 1)
                    {
                        footerIconInfo.Checked = true;
                    }
                    else if (footerIcon == 2)
                    {
                        footerIconWarning.Checked = true;
                    }
                    else if (footerIcon == 3)
                    {
                        footerIconQuestion.Checked = true;
                    }
                    else if (footerIcon == 4)
                    {
                        footerIconNone.Checked = true;
                    }
                    else
                    {
                        footerIconNone.Checked = true;
                    }
                    customButtonTextTextBox.Text = customButtonText;


                }

            }
        }

        
    }
}
