from prefect import task, flow


@task
def start_bloodhound():
    print("Starting Bloodhound")

@task
def generate_environment():
    print("Generating Environment")

@task
def create_client():
    print("Creating Client")

@task
def get_domains():
    print("Getting Domains")

@flow(name="Path selection", log_prints=True)
def select_path():
    start_bloodhound()
    generate_environment()
    create_client()
    get_domains()

if __name__ == "__main__":
    select_path()