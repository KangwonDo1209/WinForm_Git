using System.Diagnostics;
using System.Net;
using System.Security.Policy;
using System.Xml;

namespace Search_Weather
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void ParseWeatherData(string xmlData)
		{
			richTextBox1.Clear();

			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(xmlData);

			XmlNode categoryNode = xmlDoc.SelectSingleNode("//category");
			string location = categoryNode != null ? categoryNode.InnerText : "Unknown Location";
			textBox2.Text = location;

			XmlNodeList dataNodes = xmlDoc.GetElementsByTagName("data");


			DateTime today = DateTime.Now.Date; // ���� ��¥
			int hoursToDisplay = 12;

			for (int i = 0; i < Math.Min(dataNodes.Count, hoursToDisplay); i++)
			{
				XmlNode dataNode = dataNodes[i];

				string day = dataNode["day"].InnerText;
				string hour = dataNode["hour"].InnerText;
				string temp = dataNode["temp"].InnerText;
				string wfKor = dataNode["wfKor"].InnerText;
				string reh = dataNode["reh"].InnerText;

				// ��¥ ���
				DateTime forecastDate = today.AddDays(int.Parse(day));
				int hourInt = int.Parse(hour);

				// ����/���� ��ȯ
				string period = hourInt >= 12 ? "����" : "����";
				int displayHour = hourInt % 12;
				if (displayHour == 0) displayHour = 12;

				// ����ȭ�� ��¥ �� �ð� ���
				string formattedDate = $"{forecastDate.Month}�� {forecastDate.Day}�� {period} {displayHour}��";

				// ��� ���
				richTextBox1.AppendText($"�ð�: {formattedDate}, �µ�: {temp}��C, ����: {wfKor}, ����: {reh}%\n");
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "https://www.weather.go.kr/w/rss/dfs/hr1-forecast.do?zone=" + textBox1.Text;

				WebRequest wr = WebRequest.Create(query);
				wr.Method = "GET";

				try
				{
					WebResponse wrs = wr.GetResponse();
					Stream s = wrs.GetResponseStream();
					StreamReader sr = new StreamReader(s);

					string xmlData = sr.ReadToEnd();
					ParseWeatherData(xmlData);

					sr.Close();
					s.Close();
					wrs.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
			catch (Exception ex)
			{
				// ���� �߻� �� �޽����ڽ��� ǥ��
				MessageBox.Show("�����͸� �ҷ����� �� ������ �߻��߽��ϴ�: " + ex.Message);
			}
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string link = button2.Text;
			try
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = link,
					UseShellExecute = true // �⺻ �� ���������� URL�� ���ϴ�
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show("������ �߻��߽��ϴ�: " + ex.Message);
			}
		}
	}
}
