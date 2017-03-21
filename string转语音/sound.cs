using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace string转语音
{
    public class sound
    {
        private sound() { }
        public static readonly sound instance = new sound();
        private SpeechSynthesizer ss = new SpeechSynthesizer();//内容语音值

        public void soundspeek(string str)
        {
            ss.Rate = -1;//语速条
            ss.Volume = 100;//音量
            ss.SpeakAsync(str);
        }

    }
}
