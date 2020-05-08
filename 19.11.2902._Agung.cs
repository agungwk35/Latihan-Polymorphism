// Perbaikan
#include <iostream>
#include <cstdlib>

using namespace std;

struct Barang
{
	int jumlah;
	string nama;
	string merk;
	int harga;	
};

void input_data(Barang &brg);
void print_data(Barang &brg);

int main()
{
	Barang brg[25];
	int x, id, pilihan;
	
	opsi:
	cout << "Aplikasi Input Data Barang Elektronik" << endl;
	cout << "------------------------------------" << endl;
	cout << "Banyak Data Barang yang akan di inputkan : ";
	cin >> x;
	cout << "------------------------------------" << endl;
	
	for (int i = 0; i < x; i++)
	{
		system ("cls");
		cout << "Barang Elektronik ke-"<<(i+1)<<endl;
		cout << "------------------------------------" << endl;
		input_data(brg[i]);
	}
	

	cari:
	cout << "Tampilkan Data Barang no. : ";
	cin >> id;
	if(id <= x)
	{
		print_data(brg[id-1]);
		cout << "----------------------------"<<endl;
		cout << "1. Cari Data Barang Elektronik"<<endl;
		cout << "2. Buat Data Baru Barang Elektronik"<<endl;
		cout << "3. Keluar dari Aplikasi"<<endl; 
		cout << "Pilihan : ";
		cin>>pilihan;
		if(pilihan == 1){
			goto cari;
		}
		else if (pilihan == 2)
		{
			goto opsi;
		}
		else
		{
			exit(0);
		}
	}
	else
	{
		cout << "Data Tidak Ada";
		cout << "1. Cari Data Barang Elektronik"<<endl;
		cout << "2. Buat Data Baru Barang Elektronik"<<endl;
		cout << "3. Keluar dari Aplikasi"<<endl; 
		cout << "Pilihan : ";
		cin>>pilihan;
		if(pilihan == 1){
			goto cari;
		}
		else if (pilihan == 2)
		{
			goto opsi;
		}
		else
		{
			exit(0);
		}
	}
	return 0;
}

void input_data(Barang &brg)
{
	cout << "Input data Barang Elektronik" <<endl;
	cout << "Jumlah Barang Elektronik : "; 
	cin >> brg.jumlah;
	cin.ignore(1, '\n');
	cout << "Nama Barang Elektronik   : "; 
	getline(cin, brg.nama);
	cout << "Merk Barang Elektronik  : "; 
	getline(cin, brg.merk);
	cout << "Harga Barang Elektronik  : Rp. "; 
	cin >> brg.harga; 
}

void print_data(Barang &brg)
{
	system ("cls");
	cout << "--------------------------------"<<endl;
	cout << "Input data Barang Elektronik" <<endl;
	cout << "Nama Barang Elektronik : " << brg.nama << endl;
	cout << "Merk Barang Elektronik : " << brg.merk << endl;
	cout << "Jumlah Barang Elektronik : " << brg.jumlah << endl;
	cout << "Harga Barang : Rp. " << brg.harga << endl;
}

