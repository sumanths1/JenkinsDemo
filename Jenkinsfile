pipeline 
  {
      stages 
	  {
        stage('Checkout') 
		  {
            steps {
                    git url: 'https://github.com/sumanths1/JenkinsDemo', branch: 'master'
                  }
          }
		  
		 stage('Build') 
		 {
           steps 
		     {
              
			   bat "MSbuild .\\JenkinsDemo.sln
	         }
	     }
  }
 }