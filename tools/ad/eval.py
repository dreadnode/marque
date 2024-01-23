import models
from argparse import ArgumentParser


def get_current_user():
    return "user"

def get_paths_from_current_user():
    return {}

def model_select_path():
    return 0

def main():
    generate_new = False
    if not generate_new:
        done = False
        while not done:
        current_user = get_current_user()
        current_paths = get_paths_from_current_user()

        selected_path = model_select_path()
