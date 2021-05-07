using EFCoreDB.ConventionalConfigurationUnitOfWork;
using EFCoreDB.ManualConfigurationUnitOfWork;
using EFCoreDB.MixedConfigurationUnitOfWork;
using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using EFCoreDB.Models.ManualConfiguration;
using EFCoreDB.Models.MixedConfiguration;
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

        public DelegateCommand AddInitialDataMCCommand
        { get; private set; }

        public DelegateCommand DeleteAllDataMCCommand
        { get; private set; }

        #endregion

        public MainWindowViewModel()
        {
            AddInitialDataCCCommand = new DelegateCommand(ExecuteAddInitialData);
            DeleteAllDataCommand = new DelegateCommand(ExecuteDeleteAllData);

            AddInitialDataFACommand = new DelegateCommand(ExecuteAddInitialDataFA);
            DeleteAllDataFACommand = new DelegateCommand(ExecuteDeleteAllDataFA);

            AddInitialDataMCCommand = new DelegateCommand(ExecuteAddInitialDataMC);
            DeleteAllDataMCCommand = new DelegateCommand(ExecuteDeleteAllDataMC);
        }

        #region Conventional Configuration

        private void ExecuteAddInitialData(object obj)
        {
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                FDMInitialDataCC fDMInitialDataCC = new FDMInitialDataCC();
                uow.FDMProcessCCRepo.UpdateRange(fDMInitialDataCC.FDMProcessCCList);
                uow.SaveChanges();
                MessageBox.Show("Initial Data added successfully.");
            }
        }

        private void ExecuteDeleteAllData(object obj)
        {
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                List<FDMProcessCC> fDMProcessCCList = uow.FDMProcessCCRepo.GetAll().Result;
                uow.FDMProcessCCRepo.DeleteRange(fDMProcessCCList);
                uow.SaveChanges();
                MessageBox.Show("All Processes deleted successfully.");
            }
        }

        #endregion

        #region Manual Configuration (Fluent API)

        private void ExecuteAddInitialDataFA(object obj)
        {
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                InitialDataFA initialDataFA = new InitialDataFA();
                uow.ProcessFARepo.UpdateRange(initialDataFA.ProcessFAList);
                uow.SaveChanges();
                MessageBox.Show("Initial Data added successfully.");
            }
        }

        private void ExecuteDeleteAllDataFA(object obj)
        {
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                List<ProcessFA> ProcessFAList = uow.ProcessFARepo.GetAll().Result;
                uow.ProcessFARepo.DeleteRange(ProcessFAList);
                uow.SaveChanges();
                MessageBox.Show("All Processes deleted successfully.");
            }
        }

        #endregion

        #region Mixed Configuration

        private void ExecuteAddInitialDataMC(object obj)
        {
            using(UnitOfWorkMC uow = new UnitOfWorkMC())
            {
                InitialDataMC initialDataMC = new InitialDataMC();
                uow.ProcessMCRepo.UpdateRange(initialDataMC.ProcessMCList);
                uow.SaveChanges();
                MessageBox.Show("Initial Data added successfully.");
            }
        }

        private void ExecuteDeleteAllDataMC(object obj)
        {
            using(UnitOfWorkMC uow = new UnitOfWorkMC())
            {
                List<ProcessMixedConfiguration> ProcessMCList = uow.ProcessMCRepo.GetAll().Result;
                uow.ProcessMCRepo.DeleteRange(ProcessMCList);
                uow.SaveChanges();
                MessageBox.Show("All Processes deleted successfully.");
            }
        }

        #endregion
    }
}
