using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSettings;


namespace RegExpTest
{
    public partial class RegExpTest : Form
    {
        public RegExpTest()
        {
            InitializeComponent();

            #region Выпилено в пространство имён FileSettings в метод PositionXY.Start(this)
            /*
            var appSettings = ConfigurationManager.AppSettings;
            //Считываем координаты экрана последнего запуска приложения
            string StartPositionX = appSettings["StartPositionX"] ?? "Not Found";
            string StartPositionY = appSettings["StartPositionY"] ?? "Not Found";
            try
            {
                //Говорим что сами Вручную укажем координаты и не надо нам ничего
                this.StartPosition = FormStartPosition.Manual;
                //Получаем интовые значения
                int IntStartPositionX = Convert.ToInt16(StartPositionX);
                int IntStartPositionY = Convert.ToInt16(StartPositionY);
                if (IntStartPositionX <= 1024 && IntStartPositionY <= 768)
                {
                    //применяем считанные координаты
                    this.SetDesktopLocation(IntStartPositionX, IntStartPositionY);
                }
                else
                {
                    //MessageBox.Show("больше чем 1024 768");
                    throw new Exception("Не получится отобразить используя старые координаты");
                }
            }
            /*Exception возникнет, когда:
                1) в файле нет подобных записей, выдаст Not found -> не сможет преобр. в Int;
                2) в файле указаны тексты, вместо цыфорок;
                3) указанные координаты выходят за пределы 1024 768 (throw new Exception);
             * во всех этих случаях - рисуем форму в центре экрана
             */
            /*
            catch
            {
                //MessageBox.Show("либо нету, либо написаны не Инт значения, либо \"больше чем 1024 768\"");
                //рисуем по центру
                this.CenterToScreen();
            }
            */
            #endregion

            //Стартуем текущую форму со значениями Х Y из конф. файла
            PositionXY.Start(this);

            //стираем лейбл, говорящий об ошибках
            toolStripStatusLabelTextError.Text = labelUpperTextError.Text = null;

            //отключаем текст бокс для текста замены:
            labelForReplace.ForeColor = Color.Gray;
            //labelForReplace.Refresh();
            textBoxReplacementText.Text = "Текст замены. Используется только для метода замены (replace)";
            textBoxReplacementText.Enabled = false;
        }

        enum RegExpMethod
        {
            IsMatch,
            Replace
        }
        //По умолчанию при старте программы чекнут Replace
        RegExpMethod ChoisedRegExpMethod = RegExpMethod.IsMatch;

        private void ControlsForReplace_Disabled()
        {

            //отключаем текст бокс для текста замены:
            labelForReplace.ForeColor = Color.Gray;
            textBoxReplacementText.Text = "Текст замены. Используется только для метода замены (replace)";
            textBoxReplacementText.Enabled = false;
        }

        private void ControlsForReplace_Enabled()
        {
            //отключаем текст бокс для текста замены:
            labelForReplace.ForeColor = Color.Black;
            //Если текст стандартный, то убираем его
            if (textBoxReplacementText.Text == "Текст замены. Используется только для метода замены (replace)")
            {
                textBoxReplacementText.Text = null;
            }
            textBoxReplacementText.Enabled = true;
        }

        #region Эти методы уже не нужны, поскольку у всех контролов указан один единственный метод RegExpMainEvent
        //Позволит моментально находить результат рег выраж. при смене метода
        /*
        private void RegExpMethodChanged(object sender, EventArgs e)
        {
            //Если поменяли метод, то надо стереть результат
            textBoxResultText.Text = null;

            //Выполняем основной метод 
            RegExpOrInputTextChanged(sender, e);
        }
         */
        /*
        private RegExpMethod GetRegExpMethod()
        {

            return ChoisedRegExpMethod;
        }
         */
        #endregion

        private void RegExpMainEvent(object sender, EventArgs e)
        {
            //Стираем предыдущий результат
            textBoxResultText.Text = null;

            //Очищаем лейбл говорящий об ошибках
            toolStripStatusLabelTextError.Text = labelUpperTextError.Text = null;

            //чекаем какая радиокнопка выбрана и запоминаем результат
            if (radioButtonIsMatch.Checked)
            {
                //запоминаем выбранный метод
                ChoisedRegExpMethod = RegExpMethod.IsMatch;
            }

            if (radioButtonReplace.Checked)
            {
                //Включаем поле для Replace
                ControlsForReplace_Enabled();

                //запоминаем выбранный метод
                ChoisedRegExpMethod = RegExpMethod.Replace;
                //MessageBox.Show(radioButtonReplace.Text);
            }
            else
            {
                //Отключаем поле для Replace, так как выбран метод, НЕ Replace
                ControlsForReplace_Disabled();
            }


            //Проверяем, установлен ли флаг использования рег. выраж. без учёта регистра
            //Объявим переменную опций для регулярки
            RegexOptions options = RegexOptions.None;
            if (checkBoxIgnoreCase.Checked)
            {
                //Если да, то добавляем данную опцию
                options = RegexOptions.IgnoreCase;
            }


            //MessageBox.Show("текст изменён");


            switch (ChoisedRegExpMethod)
            {
                case RegExpMethod.IsMatch:

                    try
                    {
                        Regex rgx = new Regex(textBoxRegExp.Text, options);

                        //Если стоит флаг "всё поле одной строкой", то убираем переносы строк
                        if (checkBoxInputTextAsOneString.Checked)
                        {
                            textBoxResultText.Text = rgx.IsMatch(textBoxInputText.Text.Replace(Environment.NewLine, " ")).ToString();
                        }
                        else
                        {
                            //Не удаляя переносы строк
                            textBoxResultText.Text = rgx.IsMatch(textBoxInputText.Text).ToString();
                        }
                        
                        //MessageBox.Show("IsMatch");
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Кривой Рег експ");
                        labelUpperTextError.Text = "Ошибка:";
                        toolStripStatusLabelTextError.Text = ex.Message;

                    }
                    break;

                case RegExpMethod.Replace:
                    try
                    {
                        Regex rgx = new Regex(textBoxRegExp.Text, options);

                        //1000 - Указали что надо делать замену в 1000 строках
                        //Если стоит флаг "всё поле одной строкой", то убираем переносы строк
                        if (checkBoxInputTextAsOneString.Checked)
                        {
                            textBoxResultText.Text = rgx.Replace(textBoxInputText.Text.Replace(Environment.NewLine, " "), textBoxReplacementText.Text, 1000);
                        }
                        else
                        {
                            //Не удаляя переносы строк
                            textBoxResultText.Text = rgx.Replace(textBoxInputText.Text, textBoxReplacementText.Text, 1000);
                        }

                        

                        //И пройдёмся по всем строкам
                        /*
                        foreach (string SingleLine in textBoxInputText.Lines) 
                        {
                            textBoxResultText.Text = textBoxResultText.Text + rgx.Replace(SingleLine, textBoxReplacementText.Text,1000);
                        }
                         */
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Кривой Рег експ");
                        labelUpperTextError.Text = "Ошибка:";
                        toolStripStatusLabelTextError.Text = ex.Message;
                    }
                    break;
            }
        }

        private void RegExpTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Запоминаем координаты запуска, записав их в конф. файл
            FileSettings.ChangeSettings.AddSetting("StartPositionX", this.Location.X.ToString());
            FileSettings.ChangeSettings.AddSetting("StartPositionY", this.Location.Y.ToString());
        }
    }
}
