namespace Product
{
    public class Laptop
    {
        string _ram;
        string _rom;
        string _model;
        string _processor;

        public Laptop(string model, string ram, string rom, string processor)
        {
            _model = model;
            _ram = ram;
            _rom = rom;
            _processor = processor;
        }
        public override string ToString()
        {
            return $"Model: {_model}" + $"Ram: {_ram}" + $"Rom: {_rom}" + $"Processor{_processor}";
        }
    }
}