using System;
using System.Speech.Synthesis;
using System.Runtime.Versioning;

namespace Cyber_Awareness_Chat
{
    [SupportedOSPlatform("windows")]
    public class AudioHelper
    {
        private readonly SpeechSynthesizer synthesizer;

        public AudioHelper()
        {
            synthesizer = new SpeechSynthesizer();
            synthesizer.Rate = 0;    // -10 (slowest) to 10 (fastest), 0 is normal
            synthesizer.Volume = 100; // 0 to 100
        }

        // ─── PLAY VOICE GREETING ──────────────────────────────────
        public void PlayVoiceGreeting()
        {
            Speak("Welcome to the Cyber Awareness Chat. Ask me anything about staying safe online.");
        }

        // ─── SPEAK ANY TEXT ───────────────────────────────────────
        public void Speak(string text)
        {
            try
            {
                synthesizer.SpeakAsync(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Speech error: " + ex.Message);
            }
        }

        // ─── SPEAK AND WAIT UNTIL DONE ────────────────────────────
        public void SpeakSync(string text)
        {
            try
            {
                synthesizer.Speak(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Speech error: " + ex.Message);
            }
        }

        // ─── STOP SPEAKING ────────────────────────────────────────
        public void StopSpeaking()
        {
            synthesizer.SpeakAsyncCancelAll();
        }

        // ─── CLEAN UP ─────────────────────────────────────────────
        public void Dispose()
        {
            synthesizer.Dispose();
        }
    }
}