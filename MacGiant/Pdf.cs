using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace MacGiant
{
    class Pdf
    {
        public void GerarPdf(DataGridView resultado, int tipo){
        try
            {
                PdfPTable pdfTable = new PdfPTable(resultado.ColumnCount);
                pdfTable.DefaultCell.Padding = 5;
                pdfTable.WidthPercentage = 80;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                
                
                pdfTable.DefaultCell.BorderWidth = 1;


                //adcionando linhas ao reader
                foreach (DataGridViewColumn column in resultado.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in resultado.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        String valor = cell.Value.ToString();
                        pdfTable.AddCell(valor);
                    }
                }

                //Exporting to PDF
                string folderPath = "C:\\Relatórios\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                using (FileStream stream = new FileStream(folderPath + "Relatório Mac Giant.pdf"  , FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

                   Image logo = Image.GetInstance("logo.jpg");
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    
                   logo.Alignment = Element.ALIGN_CENTER;                    
                   pdfDoc.Add(logo);

                    pdfDoc.Add(new Paragraph("\n"));
                    pdfDoc.Add(new Paragraph("\n"));

                    if(tipo == 0){
                    Paragraph Ph = new Paragraph("Relatório padrão 1");
                    Ph.Alignment = Element.ALIGN_CENTER;
                    Ph.Font.SetStyle(1);
                    Ph.Font.Size = 20;
                    pdfDoc.Add(Ph);
                    Paragraph hora = new Paragraph(DateTime.Now.ToString());
                    hora.Alignment = Element.ALIGN_RIGHT;
                    pdfDoc.Add(hora);
                    }
                    else if(tipo == 1)
                    {
                        Paragraph Ph = new Paragraph("Relatório padrão 2");
                        Ph.Alignment = Element.ALIGN_CENTER;
                        Ph.Font.SetStyle(1);
                        Ph.Font.Size = 20;
                        pdfDoc.Add(Ph);
                        Paragraph hora = new Paragraph(DateTime.Now.ToString());
                        hora.Alignment = Element.ALIGN_RIGHT;
                        pdfDoc.Add(hora);
                    }
                    else if (tipo == 2)
                    {
                        Paragraph Ph = new Paragraph("Relatório personalizado");
                        Ph.Alignment = Element.ALIGN_CENTER;
                        Ph.Font.SetStyle(1);
                        Ph.Font.Size = 20;
                        pdfDoc.Add(Ph);
                        Paragraph hora = new Paragraph(DateTime.Now.ToString());
                        hora.Alignment = Element.ALIGN_RIGHT;
                        pdfDoc.Add(hora);
                    }
                    else
                    {
                        Paragraph Ph = new Paragraph("Relatório");
                        Ph.Alignment = Element.ALIGN_CENTER;
                        Ph.Font.SetStyle(1);
                        Ph.Font.Size = 20;
                        pdfDoc.Add(Ph);
                        Paragraph hora = new Paragraph(DateTime.Now.ToString());
                        hora.Alignment = Element.ALIGN_RIGHT;
                        pdfDoc.Add(hora);
                    }

                    pdfDoc.Add(new Paragraph("\n"));

                    VerticalPositionMark linha = new LineSeparator();
                    pdfDoc.Add(linha);

                    pdfDoc.Add(new Paragraph("\n"));
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();

                }

                MessageBox.Show("Relatório gerado com sucesso !","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("Explorer", "C:\\Relatórios");
            }
            catch(Exception e2)
            {
                String msg = "Favor gerar uma consulta !";

                MessageBox.Show(msg +e2.ToString(),"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
    }
}
