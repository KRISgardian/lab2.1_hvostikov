using System.ComponentModel.Design;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
namespace mainDll;
public class ImageGenerator // Конструктор создания .png файлов
{
    public static string ?fileName { get; set; } //Имя файла с расширением .png
    public static byte[] ?textToWrite { get; set; } //Информация с типом byte записываемая в файл 
    private struct ImageStructPNG //Структура .png включающая заголовки и payload
    {
        public static byte[] _HEADER = { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A }; //Заголовок файла 
        public struct IHDR //IHDR чанк содержит базовую информацию об изображении. Представление изображения 128х128 {R,G,B}
        {
            public static byte[] _IHDR = { 0x31, 0x30, 0x2C, 0x34 }; //Хедер IDHR чанка
            public static byte[] _WIDHT = { 0x00, 0x00, 0x00, 0x80 }; //Ширина изображения 128 пикселей
            public static byte[] _HEIGHT = { 0x00, 0x00, 0x00, 0x80 }; //Высота изображения 128 пиксилей
            public static byte _BITDEPTH = 0x04; // Глубина бит на выборку 4 
            public static byte _COLORTYPE = 0x02; // 2 - значение интерпретируемое как использование только цвета
            public static byte _COMPRESSIONMETHOD = 0x00; //Флаг использованного типа компрессии. Доступно только 0 значение
            public static byte _FILTERMETHOD = 0x00; //Флаг используемого метода фильтрации. Доступно только значение 0
            public static byte _INTERLACEMETHOD = 0x00; //Флаг используемого метода чересстрочной развертки. Значение 0 означает отсутствие таковой
        }
        public struct IDAT //IDAT чанк содержит данные изображения
        {
            public static byte[] _IDAT = { 0x49, 0x44, 0x41, 0x54 }; //Хедер IDAT чанка
            public static int[] _DATA { get; set; }

        }
        public static byte[] _WHITERGB = { 0xff, 0xff, 0xff };
        public static byte[] _GREENRGB = { 0x00, 0xc8, 0x00 };
        public static byte[] _IEND = { 0x49, 0x45, 0x4e, 0x44 }; //Флаг конца данных
    }
    public static int IDATGenerator(int height, int width)
    {
        try
        {
            int resolution = 128 * 128;
            if(height == width) {
                height = 64;  width = 64;
                int cubeResolution = height * width;
                int start = 0;
                int temp1 = 128 - (width / 2 + (width));
                int end = temp1 * width;

                ImageStructPNG.IDAT._DATA[0] = start;
                ImageStructPNG.IDAT._DATA[1] = end;
                ImageStructPNG.IDAT._DATA[2] = 255;
                Console.WriteLine();

                
            }
            
            

            return 0;
        }
        catch{ Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[ERROR] IDATGenerator function error"); Console.ResetColor(); return 1; }
    }
    public static int ImageGeneratorPNG(string path, int idataHeight, int idataWidth) //Функция создания .png файлов
    {
        try
        {
            IDATGenerator(idataHeight, idataWidth);
            //File.Create(path);
            //File.WriteAllBytes(fileName, textToWrite);
            return 0;
        }
        catch { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[ERROR] ImageGeneratorPNG function error"); Console.ResetColor(); return 1; }
    }
    
}

public class Environments // Конструктор включающий необходимые функции
{
    private const string path = "imgs"; //Название директории содержащей .png файл 
    private const string filesName = "*.png"; //Имя файлов .png 
    public static int FileExists() //Возвращает True если файла не существует
    {
        try
        {
            IEnumerable<string> output; 
            output = Directory.EnumerateFiles(path, filesName);
            bool result = output.Any();
            if (result) { return 0; }
            else { return 1; }
        }
        catch { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[ERROR] FileExists function error"); Console.ResetColor(); return 1; }
        
    }
    public static int FileRemove() //Возвращает True если директория и все подфайлы удалены
    {
        try
        {
            Directory.Delete(path, true);
            return 0;
        }
        catch { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[ERROR] FileRemove function error"); Console.ResetColor(); return 1; }
    }   
    public static int FileCreate() {
        try
        {
            Directory.CreateDirectory(path);
            return 0;
        }
        catch { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[ERROR] FileCreate function error"); Console.ResetColor(); return 1; }
    }
    public static int Main(int idataWidth, int idataHeight) //Вызывается только эта функция так как она вызывает все остальные функции и регламентирует их ответы
    {
        try
        {
            if(!Directory.Exists(path)) { FileCreate(); } //Создает директорию если ее не существует
            if(FileExists() == 1) { ImageGenerator.ImageGeneratorPNG(path, idataWidth, idataHeight); } //Если директория пустая возвращает 0
            else if(FileExists() == 0) { FileRemove(); FileCreate(); } //Если директория не пустая она пересоздается
            return 0;
        }
        catch { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[ERROR] Main function error"); Console.ResetColor(); return 1; }
    }
}
