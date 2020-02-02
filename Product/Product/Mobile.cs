namespace Product
{
    public class Mobile
    {
        string _model;
        string _ram;
        string _rom;
        string _chipset;
        public Mobile(string model,string ram,string rom,string chipset)
        {
            _model = model;
            _ram = ram;
            _rom = rom;
            _chipset = chipset;
        }
        public override string ToString()
        {
            return $"Model: {_model}\nRam: {_ram}\nRom: {_rom}\nChipset: {_chipset}";
        }
    }
}