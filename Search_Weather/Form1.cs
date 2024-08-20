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


			DateTime today = DateTime.Now.Date; // 오늘 날짜
			int hoursToDisplay = 12;

			for (int i = 0; i < Math.Min(dataNodes.Count, hoursToDisplay); i++)
			{
				XmlNode dataNode = dataNodes[i];

				string day = dataNode["day"].InnerText;
				string hour = dataNode["hour"].InnerText;
				string temp = dataNode["temp"].InnerText;
				string wfKor = dataNode["wfKor"].InnerText;
				string reh = dataNode["reh"].InnerText;

				// 날짜 계산
				DateTime forecastDate = today.AddDays(int.Parse(day));
				int hourInt = int.Parse(hour);

				// 오전/오후 변환
				string period = hourInt >= 12 ? "오후" : "오전";
				int displayHour = hourInt % 12;
				if (displayHour == 0) displayHour = 12;

				// 형식화된 날짜 및 시간 출력
				string formattedDate = $"{forecastDate.Month}월 {forecastDate.Day}일 {period} {displayHour}시";

				// 결과 출력
				richTextBox1.AppendText($"시간: {formattedDate}, 온도: {temp}°C, 날씨: {wfKor}, 습도: {reh}%\n");
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
				// 에러 발생 시 메시지박스로 표시
				MessageBox.Show("데이터를 불러오는 중 오류가 발생했습니다: " + ex.Message);
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
					UseShellExecute = true // 기본 웹 브라우저에서 URL을 엽니다
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show("오류가 발생했습니다: " + ex.Message);
			}
		}
	}
}
