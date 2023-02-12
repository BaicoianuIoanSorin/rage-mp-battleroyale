using System;

namespace mygamemode
{
    public class Logs
    { 
        public static void INFO(String message) {
            Console.WriteLine($"[INFO] {message}");
        }
        
        public static void WARNING(String message) {
            Console.WriteLine($"[WARNING] {message}");
        }

        public static void ERROR(String message) {
            Console.WriteLine($"[ERROR] {message}");
        } 
    }
}