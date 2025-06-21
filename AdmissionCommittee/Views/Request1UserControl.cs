using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace AdmissionCommittee.Views;

public partial class Request1UserControl : UserControl
{
    public Request1UserControl()
    {
        InitializeComponent();
        wrap1.Image = MainForm.ResourceLoader.LoadImageFromResources("Wrap1.png");
        wrap2.Image = MainForm.ResourceLoader.LoadImageFromResources("Wrap2.png");
        wrap3.Image = MainForm.ResourceLoader.LoadImageFromResources("Wrap3.png");
        saveButton.Image = MainForm.ResourceLoader.LoadImageFromResources("Save.png");
        clearButton.Image = MainForm.ResourceLoader.LoadImageFromResources("Clear.png");
    }

    private void wrap1_MouseEnter(object sender, EventArgs e)
    {
        wrap1.Image = MainForm.ResourceLoader.LoadImageFromResources("Wrap1Light.png");
    }

    private void wrap1_MouseLeave(object sender, EventArgs e)
    {
        wrap1.Image = MainForm.ResourceLoader.LoadImageFromResources("Wrap1.png");
    }

    private void wrap2_MouseEnter(object sender, EventArgs e)
    {
        wrap2.Image = MainForm.ResourceLoader.LoadImageFromResources("Wrap2Light.png");
    }

    private void wrap2_MouseLeave(object sender, EventArgs e)
    {
        wrap2.Image = MainForm.ResourceLoader.LoadImageFromResources("Wrap2.png");
    }

    private void wrap3_MouseEnter(object sender, EventArgs e)
    {
        wrap3.Image = MainForm.ResourceLoader.LoadImageFromResources("Wrap3Light.png");
    }

    private void wrap3_MouseLeave(object sender, EventArgs e)
    {
        wrap3.Image = MainForm.ResourceLoader.LoadImageFromResources("Wrap3.png");
    }

    private void wrap1_MouseDown(object sender, MouseEventArgs e)
    {
        wrap1.Location = new Point(wrap1.Location.X, wrap1.Location.Y + 1);
    }

    private void wrap1_MouseUp(object sender, MouseEventArgs e)
    {
        wrap1.Location = new Point(wrap1.Location.X, wrap1.Location.Y - 1);
        textBoxDirection.Text = "Архитектура";
        wrapPanel.Visible = !wrapPanel.Visible;
    }

    private void wrap2_MouseDown(object sender, MouseEventArgs e)
    {
        wrap2.Location = new Point(wrap2.Location.X, wrap2.Location.Y + 1);
    }

    private void wrap2_MouseUp(object sender, MouseEventArgs e)
    {
        wrap2.Location = new Point(wrap2.Location.X, wrap2.Location.Y - 1);
        textBoxDirection.Text = "ИСТ";
        wrapPanel.Visible = !wrapPanel.Visible;
    }

    private void wrap3_MouseDown(object sender, MouseEventArgs e)
    {
        wrap3.Location = new Point(wrap3.Location.X, wrap3.Location.Y + 1);
    }

    private void wrap3_MouseUp(object sender, MouseEventArgs e)
    {
        wrap3.Location = new Point(wrap3.Location.X, wrap3.Location.Y - 1);
        textBoxDirection.Text = "Социология";
        wrapPanel.Visible = !wrapPanel.Visible;
    }

    private void wrapButton_MouseDown(object sender, MouseEventArgs e)
    {
        wrapButton.Location = new Point(wrapButton.Location.X, wrapButton.Location.Y + 1);
    }

    private void wrapButton_MouseUp(object sender, MouseEventArgs e)
    {
        wrapPanel.Visible = !wrapPanel.Visible;
        wrapButton.Location = new Point(wrapButton.Location.X, wrapButton.Location.Y - 1);
    }

    private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void ValidateScoreRange(TextBox textBox, int minValue, int maxValue)
    {
        if (int.TryParse(textBox.Text, out int value))
        {
            if (value < minValue)
            {
                textBox.Text = minValue.ToString();
                textBox.Focus();
            }
            else if (value > maxValue)
            {
                textBox.Text = maxValue.ToString();
                textBox.Focus();
            }
        }
        else
        {
            textBox.Text = "0";
            textBox.Focus();
        }
    }

    private void ScoreTextBox_Validated(object sender, EventArgs e)
    {
        TextBox textBox = sender as TextBox;

        switch (textBox.Name)
        {
            case "textBoxMath":
                ValidateScoreRange(textBox, 40, 100);
                break;
            case "textBoxRussian":
                ValidateScoreRange(textBox, 40, 100);
                break;
            case "textBoxAdditional":
                ValidateScoreRange(textBox, 40, 100);
                break;
            case "textBoxAddPoints":
                ValidateScoreRange(textBox, 0, 10);
                break;
        }
    }
    private void ClearForm()
    {
        textBoxCode.Clear();
        textBoxFIO.Clear();
        textBoxDirection.Clear();
        textBoxMath.Clear();
        textBoxRussian.Clear();
        textBoxAdditional.Clear();
        textBoxAddPoints.Clear();
    }
    
    private void saveButton_MouseEnter(object sender, EventArgs e)
    {
        saveButton.Image = MainForm.ResourceLoader.LoadImageFromResources("SaveLight.png");
    }

    private void saveButton_MouseLeave(object sender, EventArgs e)
    {
        saveButton.Image = MainForm.ResourceLoader.LoadImageFromResources("Save.png");
    }
    
    private void clearButton_MouseEnter(object sender, EventArgs e)
    {
        clearButton.Image = MainForm.ResourceLoader.LoadImageFromResources("ClearLight.png");
    }

    private void clearButton_MouseLeave(object sender, EventArgs e)
    {
        clearButton.Image = MainForm.ResourceLoader.LoadImageFromResources("Clear.png");
    }
    
    private void clearButton_MouseDown(object sender, MouseEventArgs e)
    {
        clearButton.Location = new Point(clearButton.Location.X, clearButton.Location.Y + 1);
    }

    private void clearButton_MouseUp(object sender, MouseEventArgs e)
    {
        clearButton.Location = new Point(clearButton.Location.X, clearButton.Location.Y - 1);
        ClearForm();
    }

    private void saveButton_MouseDown(object sender, MouseEventArgs e)
    {
        saveButton.Location = new Point(saveButton.Location.X, saveButton.Location.Y + 1);
    }
    private void saveButton_MouseUp(object sender, MouseEventArgs e)
    {
        saveButton.Location = new Point(saveButton.Location.X, saveButton.Location.Y - 1);
        
        if (string.IsNullOrWhiteSpace(textBoxCode.Text) ||
            string.IsNullOrWhiteSpace(textBoxFIO.Text) ||
            string.IsNullOrWhiteSpace(textBoxDirection.Text) ||
            string.IsNullOrWhiteSpace(textBoxMath.Text) ||
            string.IsNullOrWhiteSpace(textBoxRussian.Text) ||
            string.IsNullOrWhiteSpace(textBoxAdditional.Text) ||
            string.IsNullOrWhiteSpace(textBoxAddPoints.Text))
        {
            MessageBox.Show("Заполните все поля.");
            return;
        }

        string code = textBoxCode.Text;
        string fullName = textBoxFIO.Text;
        string directionText = textBoxDirection.Text.Trim();
        string mathScore = textBoxMath.Text;
        string russianScore = textBoxRussian.Text;
        string additionalScore = textBoxAdditional.Text;
        string extraPoints = textBoxAddPoints.Text;

        int directionId = -1;

        switch (directionText)
        {
            case "Архитектура":
                directionId = 1;
                break;
            case "ИСТ":
                directionId = 2;
                break;
            case "Социология":
                directionId = 3;
                break;
            default:
                MessageBox.Show("Выберите корректное направление.");
                return;
        }

        string connString = "Host=127.0.0.1;Port=5432;Database=AdmissionCommittee;Username=postgres;Password=1478";

        using (var conn = new NpgsqlConnection(connString))
        {
            try
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(@"
                    INSERT INTO requests (
                        unique_code, full_name, direction_id, 
                        math_score, russian_score, additional_discipline_score, additional_points
                    ) VALUES (
                        @code, @name, @directionId, 
                        @math, @russian, @additional, @extra
                    )", conn))
                {
                    // Добавляем параметры
                    cmd.Parameters.AddWithValue("code", code);
                    cmd.Parameters.AddWithValue("name", fullName);
                    cmd.Parameters.AddWithValue("directionId", directionId);
                    cmd.Parameters.AddWithValue("math", int.Parse(mathScore));
                    cmd.Parameters.AddWithValue("russian", int.Parse(russianScore));
                    cmd.Parameters.AddWithValue("additional", int.Parse(additionalScore));
                    cmd.Parameters.AddWithValue("extra", int.Parse(extraPoints));

                    // Выполняем запрос
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Заявка успешно сохранена!");
                    ClearForm();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Все поля с баллами должны содержать числа.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }
    }
}