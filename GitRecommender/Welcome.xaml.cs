namespace GitRecommender
{
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
        }


        // begin building DB 
        private void OnInitializeClick(object sender, EventArgs e)
        {
            //blockers: how does the SQLite thing work, veryifying each api call, what we do after this


            //setup DB
                //Make tables, etc
            
            //first build progress bar
                //get starred repos
                //for each repo below threshold get fellow stargazers and count 
                //get their starred repos below threshold and count
                // we make a request for each repo, we're limited to 5000 p/h
                // width of the progress bar is requests to be made
                // slider is requests done so far
                // time remaining is total requests / 5000 in hours



            //iterate through list of stars 
                //for each repo
                    //save as own object
                    //save stargazers as object
                    //add stargazer to process list 

                // for each fellow stargazer
                    // go through their starred repos 
                    // record relationship { User - Repo - Starred }
                    // once done mark complete in process list 
             

        }
    }
}