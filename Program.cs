Siswa siswaobj = new Siswa("Kaelz", "elcaribolabasket@gmail.com", "12456381", "siswa", "X PG 2");
Guru guruobj = new Guru("sky", "skylark@gmail.com", "986765", "guru", "Coding");

class user
{
    public string Nama;

    public string Email;

    public string Password;

    public string Role;

    public user(string nama, string email, string password, string role)
    {
        Nama = nama;
        Email = email;
        Password = password;
        Role = role;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine("Menampilkan info user");
        Console.WriteLine($"Nama = {Nama}");
        Console.WriteLine($"Role = {Role}");
    }

}

class Siswa : user
{
    public string Classname;

    public Siswa(string nama, string email, string password, string role, string classname) : base(nama, email, password, role)
    {
        Classname = classname;
    }

    public void SubmitTugas()
    {
        Console.WriteLine($"Siswa {Nama} sudah mengumpulkan tugas");
    }

}

class Guru : user
{
    public string Mapel;

    public Guru(string nama, string email, string password, string role, string mapel) : base(nama, email, password, role)
    {
        Mapel = mapel;
    }

    public void Nilai()
    {
        Console.WriteLine($"Guru {Nama} sudah memberi niali");
    }
}