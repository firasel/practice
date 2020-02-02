namespace Product
{
    public class Computer
    {
        string _name;
        string _ram;
        string _rom;
        string _company;
        public Computer(string name,string ram,string rom,string company)
        {
            _name = name;
            _ram = ram;
            _rom = rom;
            _company = company;
        }
        public override string ToString()
        {
            return $"Name: {_name}\nRam: {_ram}\nRom: {_rom}\nCompany: {_company}";
        }
    }
}