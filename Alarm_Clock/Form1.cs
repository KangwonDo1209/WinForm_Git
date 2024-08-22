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
		// Form �ε�
		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}
		// 1�ʸ��� ��ȭ
		private void timer1_Tick(object sender, EventArgs e)
		{
			timelabel.Text = "���� �ð� : " + DateTime.Now.ToString("G");
			if (isAlarmSet && DateTime.Now >= alarmDate)
			{
				isAlarmSet = false;
				PlayAlarmSound();
				MessageBox.Show("�˶� �ð��Դϴ�!", "�˶�", MessageBoxButtons.OK, MessageBoxIcon.Information);
				settimelabel.Text = "�˸� �̼���";
			}
		}
		// �˶� �Ҹ� ���
		private void PlayAlarmSound()
		{
			string path = @"AlarmSound.mp3";
			if (File.Exists(path))
			{
				player.URL = path;
				player.controls.play();
			}
		}
		// Reset ��ư
		private void button1_Click(object sender, EventArgs e)
		{
			alarmDate = DateTime.MinValue;
			settimelabel.Text = "�˸� �̼���";
			player.controls.stop();
			isAlarmSet = false;
		}
		// Set ��ư
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

			settimelabel.Text = alarmDate.ToString("G") + " �� �˸�";
			isAlarmSet = true;
		}
	}
}
