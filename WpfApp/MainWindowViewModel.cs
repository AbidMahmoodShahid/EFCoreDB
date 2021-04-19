using EFCoreDB.ConventionalConfigurationUnitOfWork;
using EFCoreDB.ManualConfigurationUnitOfWork;
using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.Common;
using WpfApp.InitialData;

namespace WpfApp
{
    public class MainWindowViewModel
    {
        #region commands

        public DelegateCommand AddInitialDataCCCommand
        { get; private set; }

        public DelegateCommand DeleteAllDataCommand
        { get; private set; }

        public DelegateCommand AddInitialDataFACommand
        { get; private set; }

        public DelegateCommand DeleteAllDataFACommand
        { get; private set; }

        #region unimplemented

        public DelegateCommand AddInitialDataMCCommand
        { get; private set; }

        public DelegateCommand DeleteAllDataMCCommand
        { get; private set; }
        #endregion

        #endregion

        public MainWindowViewModel()
        {
            AddInitialDataCCCommand = new DelegateCommand(ExecuteAddInitialData);
            DeleteAllDataCommand = new DelegateCommand(ExecuteDeleteAllData);

            AddInitialDataFACommand = new DelegateCommand(ExecuteAddInitialDataFA);
            DeleteAllDataFACommand = new DelegateCommand(ExecuteDeleteAllDataFA);
        }

        private void ExecuteAddInitialData(object obj)
        {
            using (FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                FDMInitialDataCC fDMInitialDataCC = new FDMInitialDataCC();
                uow.FDMProcessCCRepo.UpdateRange(fDMInitialDataCC.FDMProcessCCList);
                uow.SaveChanges();
                MessageBox.Show("Initial Data added successfully.");
            }
        }

        private void ExecuteDeleteAllData(object obj)
        {
            using (FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                List<FDMProcessCC> fDMProcessCCList = uow.FDMProcessCCRepo.GetAll().Result;
                uow.FDMProcessCCRepo.DeleteRange(fDMProcessCCList);
                uow.SaveChanges();
                MessageBox.Show("All Processes deleted successfully.");
            }
        }

        private void ExecuteAddInitialDataFA(object obj)
        {
            using (UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                InitialDataFA initialDataFA = new InitialDataFA();
                uow.ProcessFARepo.UpdateRange(initialDataFA.ProcessFAList);
                uow.SaveChanges();
                MessageBox.Show("Initial Data added successfully.");
            }
        }

        private void ExecuteDeleteAllDataFA(object obj)
        {
            using (UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                List<ProcessFA> ProcessFAList = uow.ProcessFARepo.GetAll().Result;
                uow.ProcessFARepo.DeleteRange(ProcessFAList);
                uow.SaveChanges();
                MessageBox.Show("All Processes deleted successfully.");
            }
        }

    }
}
