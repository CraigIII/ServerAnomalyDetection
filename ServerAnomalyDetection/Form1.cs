using Microsoft.ML;
using Microsoft.ML.Trainers;
using System.Diagnostics;
using System.Windows.Forms;

namespace ServerAnomalyDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetectServerAnomaly_Click(object sender, EventArgs e)
        {
            MLContext context = new MLContext();

            // ¥[¸ü¼Æ¾Ú
            var data = context.Data.LoadFromTextFile<ServerMetrics>("ServerMetrics.csv", separatorChar: ',', hasHeader: true);

            // Define the pipeline
            var pipeline = context.Transforms.Concatenate("Features", nameof(ServerMetrics.cpu), nameof(ServerMetrics.ram), nameof(ServerMetrics.disk), nameof(ServerMetrics.network))
                            .Append(context.Transforms.NormalizeMinMax("Features"))
                            .Append(context.AnomalyDetection.Trainers.RandomizedPca(featureColumnName: "Features", rank: 2));

            // Train the model
            var model = pipeline.Fit(data);


            // Get the predictions
            var transformedData = model.Transform(data);

            var predictions = context.Data.CreateEnumerable<AnomalyPrediction>(transformedData, reuseRowObject: false);

            // Output the results
            foreach (var prediction in predictions)
            {
                Trace.WriteLine($"Predicted Label: {prediction.PredictedLabel}, Score: {prediction.Score}");
            }
        }
    }
}
