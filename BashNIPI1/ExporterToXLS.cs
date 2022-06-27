using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BashNIPI1
{
    public class ExporterToXLS
    {
        public static void Export(List<TestData> exportList, string fileName)
        {
            IWorkbook workbook = new HSSFWorkbook();
            ISheet excelSheet = workbook.CreateSheet("Export");
            var excelHeaderColumns = TestData.GetDisplayNames();
            IRow headerRow = excelSheet.CreateRow(0);
            var numberColumn = 0; 
            excelHeaderColumns.ToList().ForEach(headerColumn => 
            {
                var cell = headerRow.CreateCell(numberColumn);
                cell.SetCellValue(headerColumn);
                numberColumn++;
            });
            var rowCount = 1;
            IRow row;
            exportList.ForEach(td =>
            {
                row = excelSheet.CreateRow(rowCount);
                var cellCount = 0;
                foreach (var prop in td.GetType().GetProperties())
                {
                    var cell = row.CreateCell(cellCount);
                    if (prop.GetValue(td) is string)
                    {
                        cell.SetCellValue(prop.GetValue(td).ToString());
                    }
                    if (prop.GetValue(td) is double && prop.GetValue(td) != null)
                    {
                        cell.SetCellValue((double)prop.GetValue(td));
                    }
                    if (prop.GetValue(td) is int && prop.GetValue(td) != null)
                    {
                        cell.SetCellValue((int)prop.GetValue(td));
                    }
                    if (prop.GetValue(td) is EnumTypeFlowAtDepthL && prop.GetValue(td) != null)
                    {
                        cell.SetCellValue((EnumTypeFlowAtDepthL)prop.GetValue(td) == EnumTypeFlowAtDepthL.Laminar
                            ? "Ламинарный"
                            : "Турбулентный");
                    }
                    cellCount++;
                }
                rowCount++;
            });

            for (int i = 0; i < excelHeaderColumns.Length; i++)
            {
                excelSheet.AutoSizeColumn(i);
            }

            var stream = new MemoryStream();
            workbook.Write(stream);
            FileStream file = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write);
            stream.WriteTo(file);
            file.Close();
            stream.Close();
        }

    }
}
