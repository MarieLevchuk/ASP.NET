using System;

namespace Sensors
{
    public class Report
    {
        public string Text { get; set; }

        public void CheckEnvironmentState(IEnvironmentStateChecking checker)
        {
            checker.CheckEnvironmentState();
        }
        /*здесь применяется первый из принципов SOLID. Вместо того, чтобы реализовывать два 
        принципиально разных метода (измерение температуры и измерение давления) в одном классе,
        они вынесены в отдельные: TemperatureSensor и PressureSensor*/
    }
}
