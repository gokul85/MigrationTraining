SOURCE_REPO_URL="https://github.com/gokul85/MiniProject.git"
DEST_REPO_URL="https://github.com/gokul85/PresidioTrainingMiniProject.git"

echo "Cloning the source repository..."
git clone --mirror $SOURCE_REPO_URL source-repo
cd source-repo

echo "Adding new remote for the destination repository..."
git remote add new-origin $DEST_REPO_URL

echo "Pushing repository to the destination..."
git push --mirror new-origin

echo "Archiving the old repository..."
cd ..
tar -czf source-repo-archive.tar.gz source-repo

echo "Cleaning up..."
rm -rf source-repo

echo "Repository migration completed successfully!"
