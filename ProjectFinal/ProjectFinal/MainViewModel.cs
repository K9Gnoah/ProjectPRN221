using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectFinal
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Folder> _folders;
        private ObservableCollection<Asset> _assets;
        private Asset _selectedAsset;
        private Folder _selectedFolder;
        private string _searchText;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            Folders = new ObservableCollection<Folder>();
            Assets = new ObservableCollection<Asset>();
            InitializeCommands();
        }

        public ObservableCollection<Folder> Folders
        {
            get => _folders;
            set
            {
                _folders = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Asset> Assets
        {
            get => _assets;
            set
            {
                _assets = value;
                OnPropertyChanged();
            }
        }

        public Asset SelectedAsset
        {
            get => _selectedAsset;
            set
            {
                _selectedAsset = value;
                OnPropertyChanged();
            }
        }

        public Folder SelectedFolder
        {
            get => _selectedFolder;
            set
            {
                _selectedFolder = value;
                OnPropertyChanged();
                LoadAssetsForFolder();
            }
        }

        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged();
                FilterAssets();
            }
        }

        // Commands
        public ICommand NewFolderCommand { get; private set; }
        public ICommand ImportAssetCommand { get; private set; }
        public ICommand RenameCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand SaveChangesCommand { get; private set; }

        private void InitializeCommands()
        {
            NewFolderCommand = new RelayCommand(CreateNewFolder);
            ImportAssetCommand = new RelayCommand(ImportAsset);
            RenameCommand = new RelayCommand(RenameSelected);
            DeleteCommand = new RelayCommand(DeleteSelected);
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Implement these methods next...
        private void CreateNewFolder()
        {
            // TODO: Implement
        }

        private void ImportAsset()
        {
            // TODO: Implement
        }

        private void RenameSelected()
        {
            // TODO: Implement
        }

        private void DeleteSelected()
        {
            // TODO: Implement
        }

        private void SaveChanges()
        {
            // TODO: Implement
        }

        private void LoadAssetsForFolder()
        {
            // TODO: Implement
        }

        private void FilterAssets()
        {
            // TODO: Implement
        }
    }
}
