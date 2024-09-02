import os
from flask import Flask
from .models import db, init_db, seed_db

def create_app():
    app = Flask(__name__)
    app.config['SECRET_KEY'] = 'supersecretkey'
    
    db_path = os.path.join(os.path.dirname(__file__), 'app.db')
    app.config['SQLALCHEMY_DATABASE_URI'] = f'sqlite:///{db_path}'

    db.init_app(app)
    
    with app.app_context():
        init_db()
        seed_db()
    
    from .routes import main
    app.register_blueprint(main)
    
    return app
