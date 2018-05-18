using System;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace W3DO.PdfCleanupTool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Identificando o path do arquivo
            string filePath;
            
            if (args.Length > 0)
            {
                filePath = args[0];
            } else
            {
                Console.Write("Entre com o caminho completo do arquivo PDF de origem: ");
                filePath = Console.ReadLine().Replace("\"", "");
                Console.WriteLine();
            }

            // Definindo nomes e paths
            string fileName = Path.GetFileName(filePath);
            string fullPath = Path.GetDirectoryName(filePath);
            string fileNameCopy = (fullPath + "\\" + Path.GetFileNameWithoutExtension(fileName) + "_noMetadata.pdf").Replace("\"", "");


            // Criando o objeto PDFReader
            PdfReader pdfReader = new PdfReader(filePath);
            Console.WriteLine("Iniciando remoção de metadados do arquivo...");

            // Iniciando o filestream em um contexto using
            using (FileStream fileStream = new FileStream(fileNameCopy, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // Removendo todos os metadados
                foreach (KeyValuePair<string, string> KV in pdfReader.Info)
                {
                    pdfReader.Info.Remove(KV.Key);
                }

                // Criando uma nova instancia de documento (itextsharp), criando uma cópia e "apendando" para o stream
                Document document = new Document();
                PdfCopy pdfCopy = new PdfCopy(document, fileStream);

                // Iniciando o documento
                document.Open();

                // Obtendo todas as páginas do documento e adicionando na copia
                for (int i = 1; i <= pdfReader.NumberOfPages; i++)
                {
                    pdfCopy.AddPage(pdfCopy.GetImportedPage(pdfReader, i));
                }

                // Fechando o documento para gravação do stream
                document.Close();
            }
            Console.WriteLine("Arquivo gerado com sucesso no mesmo caminho do arquivo de origem!");
            Console.WriteLine();
            Console.WriteLine("### Atenção! ###");
            Console.WriteLine();
            Console.WriteLine("Voce pode validar os metadados através da ferramenta PowerMeta:");
            Console.WriteLine("https://github.com/dafthack/PowerMeta");
            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para sair.");
            Console.ReadLine();
        }
    }
}
