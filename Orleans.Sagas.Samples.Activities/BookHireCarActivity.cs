﻿using System.Threading.Tasks;

namespace Orleans.Sagas.Samples.Activities
{
    public class BookHireCarActivity : Activity<BookHireCarConfig>
    {
        public override Task Compensate(IActivityContext context)
        {
            return Task.CompletedTask;
        }

        public override Task Execute(IActivityContext context)
        {
            context.SagaProperties.Add("NumSuitcases", 3);

            return Task.CompletedTask;
        }
    }
}