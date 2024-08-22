using System.Media;
using System.Numerics;
using System.Media;
using WMPLib;

namespace Alarm_Clock
{
	public partial class Form1 : Form
	{
		private DateTime alarmDate;
		private bool isAlarmSet = false;
		private WindowsMediaPlayer player;
		public Form1()
		{
			InitializeComponent();
			player = new WindowsMediaPlayer();
		}
		// Form 로딩
		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}
		// 1초마다 변화
		private void timer1_Tick(object sender, EventArgs e)
		{
			timelabel.Text = "현재 시간 : " + DateTime.Now.ToString("G");
			if (isAlarmSet && DateTime.Now >= alarmDate)
			{
				isAlarmSet = false;
				PlayAlarmSound();
				MessageBox.Show("알람 시간입니다!", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
				settimelabel.Text = "알림 미설정";
			}
		}
		// 알람 소리 재생
		private void PlayAlarmSound()
		{
			string path = @"AlarmSound.mp3";
			if (File.Exists(path))
			{
				player.URL = path;
				player.controls.play();
			}
		}
		// Reset 버튼
		private void button1_Click(object sender, EventArgs e)
		{
			alarmDate = DateTime.MinValue;
			settimelabel.Text = "알림 미설정";
			player.controls.stop();
			isAlarmSet = false;
		}
		// Set 버튼
		private void button2_Click(object sender, EventArgs e)
		{
			if (dateTimePicker1.Value <= DateTime.Now)
			{
				alarmDate = dateTimePicker1.Value.AddDays(1);
			}
			else
			{
				alarmDate = dateTimePicker1.Value;
			}

			settimelabel.Text = alarmDate.ToString("G") + " 에 알림";
			isAlarmSet = true;
		}
	}
}
