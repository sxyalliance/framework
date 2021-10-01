using GameFramework.DataTable;

namespace GameMain.Scripts.DataTable
{
    public class DRHero : IDataRow
    {
        public bool ParseDataRow(byte[] dataRowBytes, int startIndex, int length, object userData)
        {
            throw new System.NotImplementedException();
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int Attack { get; protected set; }

        public bool ParseDataRow(string dataRowString, object userData)
        {
            var text = dataRowString.Split('\t');
            var index = 0;
            index++;
            Id = int.Parse(text[index++]);
            Name = text[index++];
            Attack = int.Parse(text[index]);
            return true;
        }
    }
}