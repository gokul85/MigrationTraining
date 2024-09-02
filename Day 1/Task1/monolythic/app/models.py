from flask_sqlalchemy import SQLAlchemy

db = SQLAlchemy()

def init_db():
    db.create_all()

def seed_db():
    if not User.query.first():
        user1 = User(username='Alice')
        user2 = User(username='Bob')
        user3 = User(username='Jimmy')
        user4 = User(username='Tommy')
        
        db.session.add(user1)
        db.session.add(user2)
        db.session.add(user3)
        db.session.add(user4)
        
        db.session.commit()

class User(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    username = db.Column(db.String(80), unique=True, nullable=False)
