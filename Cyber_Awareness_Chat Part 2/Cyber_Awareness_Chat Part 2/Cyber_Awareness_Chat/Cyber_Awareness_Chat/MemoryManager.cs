using System.Collections.Generic;

namespace Cyber_Awareness_Chat
{
    public class MemoryManager
    {
        private readonly Dictionary<string, string> memory;

        public MemoryManager()
        {
            memory = new Dictionary<string, string>();
        }

        // ─── STORE ────────────────────────────────────────────────
        public void StoreMemory(string key, string value)
        {
            if (memory.ContainsKey(key)) //Check if the key already exists in the dictionary
                memory[key] = value;// Key exists — overwrite the existing value with the new one
            else
                memory.Add(key, value);
        }

        // ─── RECALL ───────────────────────────────────────────────
        public string RecallMemory(string key)
        {
            return memory.ContainsKey(key) ? memory[key] : null;
        }

        // ─── CHECK IF KEY EXISTS ──────────────────────────────────
        public bool HasMemory(string key) // Method to check if a specific key exists in memory
        {
            return memory.ContainsKey(key);
        }

        // ─── CLEAR ALL ────────────────────────────────────────────
        public void ClearMemory()
        {
            memory.Clear();
        }
    }
}
