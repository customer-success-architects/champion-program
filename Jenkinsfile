pipeline {
    agent any

    environment {
        PYTHON_VERSION = '3.13'  // Matching your local Python version
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Setup Python Environment') {
            steps {
                sh '''
                    python${PYTHON_VERSION} -m venv venv
                    . venv/bin/activate
                    pip install -r requirements.txt
                '''
            }
        }

        stage('Lint') {
            steps {
                sh '''
                    . venv/bin/activate
                    pip install flake8
                    flake8 . --count --select=E9,F63,F7,F82 --show-source --statistics
                '''
            }
        }

        stage('Test') {
            steps {
                sh '''
                    . venv/bin/activate
                    pytest tests/ -v
                '''
            }
        }

        stage('Build and Deploy') {
            stages {
                stage('Build') {
                    steps {
                        sh '''
                            . venv/bin/activate
                            # Add build steps here if needed
                            echo "Building application..."
                        '''
                    }
                }
                
                stage('Deploy') {
                    when {
                        branch 'main'  // Only deploy from main branch
                    }
                    steps {
                        sh '''
                            echo "Deploying application..."
                            # Add deployment steps here
                        '''
                    }
                }
            }
        }
    }

    post {
        always {
            cleanWs()  // Clean workspace after build
        }
    }
}