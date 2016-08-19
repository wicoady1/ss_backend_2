echo 'Begin Install Mono Develop + SQLite'
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb http://download.mono-project.com/repo/debian wheezy main" | sudo tee /etc/apt/sources.list.d/mono-xamarin.list
sudo apt-get update
sudo apt-get install mono-devel 
sudo apt-get install mono-complete
sudo apt-get install referenceassemblies-pcl
sudo apt-get install mono-xsp4
sudo apt-get install monodevelop
sudo apt-get install sqlite3 libsqlite3-dev
sudo apt-get install sqlitebrowser
echo 'Install Mono Develop + SQLite Done'


